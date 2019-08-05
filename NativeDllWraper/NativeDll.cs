using System;
using System.Runtime.InteropServices;

namespace NativeDllWraper
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;
    }

    public class NativeDll
    {
        [DllImport("NativeDll.dll")]
        public static extern IntPtr AllocateArrayOfInt(int count);

        [DllImport("NativeDll.dll")]
        public static extern void DeallocateArrayOfInt(IntPtr ptr);


        [DllImport("NativeDll.dll")]
        public static extern IntPtr AllocateArrayOfPoint(int count);

        [DllImport("NativeDll.dll")]
        public static extern void DeallocateArrayOfPoint(IntPtr ptr);
    }
}
