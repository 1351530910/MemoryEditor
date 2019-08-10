#pragma once

#ifdef MemoryHandler_EXPORTS
#define MemoryHandler_API __declspec(dllexport)
#else
#define MemoryHandler_API __declspec(dllimport)
#endif

#define nCores 16
#define processReadWrite 0x04
#define processCommit 0x00001000

#include <Windows.h>
#include <Psapi.h>
#include <iostream>
#include <cstddef>
#include <algorithm>
#include <atomic>
#include <vector>
#include <thread>


extern "C" MemoryHandler_API int MemSearch(const HANDLE process, const BYTE arr[], const int length, UINT64 ptrs[], const int maxcount);

extern "C" MemoryHandler_API BYTE* ReadMemory(const HANDLE process,const size_t size,const LPCVOID address);

extern "C" MemoryHandler_API BYTE ReadByte(const HANDLE process, const LPCVOID address);

extern "C" MemoryHandler_API UINT32 ReadInt32(const HANDLE process,const LPCVOID address);

extern "C" MemoryHandler_API UINT64 ReadInt64(const HANDLE process,const LPCVOID address);

extern "C" MemoryHandler_API void WriteMemory(const HANDLE process, const BYTE* data, const size_t size, const LPVOID address);

extern "C" MemoryHandler_API void WriteByte(const HANDLE process, const LPVOID address, const BYTE value);

extern "C" MemoryHandler_API void WriteInt32(const HANDLE process, const LPVOID address, const INT32 value);

extern "C" MemoryHandler_API void WriteInt64(const HANDLE process, const LPVOID address, const INT64 value);