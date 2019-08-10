#include "pch.h"
#include "MemoryHandler.h"

using namespace std;

vector<MEMORY_BASIC_INFORMATION> memInfoListArr;
UINT64* results;
atomic_int scanIndex;
atomic_int resultIndex;


void scanBlocks(const HANDLE process, const BYTE pattern[], const int length, const int maxcount) {

	while (1)
	{
		//get next block index
		int index = scanIndex.fetch_add(1);
		if (index >= memInfoListArr.size()) //check if all block scanned
		{
			return;
		}

		//read the memory block
		BYTE* buffer = new BYTE[memInfoListArr[index].RegionSize];	//the copy of the memory block
		SIZE_T cp;	//not used
		ReadProcessMemory(process, memInfoListArr[index].BaseAddress, buffer, memInfoListArr[index].RegionSize, &cp);

		UINT64 end = (UINT64)memInfoListArr[index].RegionSize;

		//loop through the block and search for the target pattern
		for (UINT64 i = 0; i < end; i++)
		{
			if (!memcmp(buffer + i, pattern, length))
			{
				//if pattern is found
				int rIndex = resultIndex.fetch_add(1);
				if (rIndex >= maxcount) //check if max limit of result reached
				{
					return;
				}
				results[rIndex] = (UINT64)memInfoListArr[index].BaseAddress + i; //save result
			}
		}
		delete[](buffer);
	}
}

int compare(const void* arg1, const void* arg2)
{
	return *(UINT64*)arg1 - *(UINT64*)arg2;
}

int MemSearch(const HANDLE process, const BYTE pattern[], const int length, UINT64 ptrs[], const int maxcount) {

	MEMORY_BASIC_INFORMATION info;	//memory information
	UINT64 p = NULL;		//current search address
	int count = 0;					//number of values found
	int index = 0;
	scanIndex = 0;
	resultIndex = 0;
	results = ptrs;


	while (VirtualQueryEx(process, (LPVOID)p, &info, sizeof(info)))
	{
		if (info.Protect == processReadWrite && info.State == processCommit)
		{
			memInfoListArr.push_back(info);
		}
		p = (UINT64)info.BaseAddress + info.RegionSize;
	}
	vector<thread> threads;
	for (size_t i = 0; i < nCores; i++)
	{
		threads.push_back(thread(scanBlocks, process, ref(pattern), length, maxcount));

	}
	for (size_t i = 0; i < nCores; i++)
	{
		threads[i].join();
	}

	results = NULL;
	qsort(ptrs, resultIndex, sizeof(UINT64),&compare);
	if (resultIndex >= maxcount) return maxcount;
	else return resultIndex;
}




BYTE* ReadMemory(const HANDLE process, const size_t size, const LPCVOID address)
{
	BYTE* data = (BYTE*)malloc(size);
	SIZE_T cp;
	ReadProcessMemory(process, address, data, size, &cp);
	return data;
}

BYTE ReadByte(const HANDLE process, const LPCVOID address)
{
	return *ReadMemory(process,1,address);
}

UINT32 ReadInt32(const HANDLE process, const LPCVOID address)
{
	return *((UINT32*)ReadMemory(process, 4, address));
}

UINT64 ReadInt64(const HANDLE process, const LPCVOID address)
{
	return *((UINT64*)ReadMemory(process, 8, address));
}

void WriteMemory(const HANDLE process, const BYTE* data, const size_t size, const LPVOID address)
{
	SIZE_T cp;
	WriteProcessMemory(process, address, data, size, &cp);
}

void WriteByte(const HANDLE process, const LPVOID address, const BYTE value)
{
	WriteMemory(process, &value, sizeof(BYTE), address);
}

void WriteInt32(const HANDLE process, const LPVOID address, const INT32 value)
{
	BYTE* data = (BYTE*)malloc(sizeof(INT32));
	memcpy(data, &value, sizeof(INT32));
	WriteMemory(process, data, sizeof(INT32), address);
	free(data);
}

void WriteInt64(const HANDLE process, const LPVOID address, const INT64 value)
{
	BYTE* data = (BYTE*)malloc(sizeof(INT64));
	memcpy(data, &value, sizeof(INT64));
	WriteMemory(process, data, sizeof(INT64), address);
	free(data);
}
