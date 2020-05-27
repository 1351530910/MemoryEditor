using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Utils
{
    /// <summary>
    /// wrapper class
    /// </summary>
    public class Wrapper
    {
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MemSearch(IntPtr process, byte[] arr, int length, UIntPtr[] ptrs,int maxcount);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte[] ReadMemory(IntPtr process,UInt64 size,UInt64 address);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Readbyte(IntPtr process, UInt64 address);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReadInt32(IntPtr process,UInt64 address);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ReadInt64(IntPtr process,UInt64 address);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WriteMemory(IntPtr process, byte[] data, UInt64 size, UInt64 address);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Writebyte(IntPtr process, UInt64 address, byte value);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WriteInt32(IntPtr process, UInt64 address, int value);
        [DllImport("Util.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WriteInt64(IntPtr process, UInt64 address, long value);

    }
}
