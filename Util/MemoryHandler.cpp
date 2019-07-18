#include "pch.h"
#include "MemoryHandler.h"

using namespace std;

int MemSearch(const HANDLE process, const BYTE pattern[], const int length, UINT64 ptrs[], const int maxcount) {

	MEMORY_BASIC_INFORMATION info;	//memory information
	unsigned char* p = NULL;		//current search address
	int count = 0;					//number of values found
	//get next block
	while (VirtualQueryEx(process, p, &info, sizeof(info)))
	{
		//protect = read/write  state = commit
		if (info.Protect == 0x04 && info.State == 0x00001000)
		{
			//read the memory block
			BYTE* buffer = new BYTE[info.RegionSize];
			SIZE_T cp;
			ReadProcessMemory(process, info.BaseAddress, buffer, info.RegionSize, &cp);

			//search for the target pattern
			UINT64 end = (UINT64)info.RegionSize;

			for (UINT64 i = 0; i < end; i++)
			{
				if (!memcmp(buffer + i, pattern, length))
				{
					ptrs[count++] = (UINT64)info.BaseAddress + i;
					if (count >= maxcount)
					{
						return count;
					}
				}
			}
			delete[](buffer);
		}
		p += info.RegionSize;
	}
	return count;
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



