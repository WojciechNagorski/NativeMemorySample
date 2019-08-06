using System;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace NativeMemorySample
{
[ShortRunJob]
[NativeMemoryProfiler]
[MemoryDiagnoser]
public class IntroNativeMemory
{
    private const int Size = 20; // Greater value could cause System.OutOfMemoryException for test with memory leaks.
    private int ArraySize = Size * Marshal.SizeOf(typeof(int));

    [Benchmark]
    public unsafe void AllocHGlobal()
    {
        IntPtr unmanagedHandle = Marshal.AllocHGlobal(ArraySize);
        Span<byte> unmanaged = new Span<byte>(unmanagedHandle.ToPointer(), ArraySize);
        Marshal.FreeHGlobal(unmanagedHandle);
    }

    [Benchmark]
    public unsafe void AllocHGlobalWithLeaks()
    {
        IntPtr unmanagedHandle = Marshal.AllocHGlobal(ArraySize);
        Span<byte> unmanaged = new Span<byte>(unmanagedHandle.ToPointer(), ArraySize);
    }
}
}