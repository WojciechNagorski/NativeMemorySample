using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using NativeDllWraper;

namespace NativeMemorySample
{
    [ShortRunJob]
    [NativeMemoryProfiler]
    [MemoryDiagnoser]
    public class IntroNativeMemoryFromNativeDll
    {
        [Benchmark]
        public void AllocManyType()
        {
            var ptr = NativeDll.AllocateArrayOfInt(200);
            ptr = NativeDll.AllocateArrayOfInt(150);
            ptr = NativeDll.AllocateArrayOfPoint(200);
        }

        [Benchmark]
        public void AllocAndFreeNativeInt()
        {
            var ptr = NativeDll.AllocateArrayOfInt(200);
            NativeDll.DeallocateArrayOfInt(ptr);
        }

        [Benchmark]
        public void AllocNativeInt()
        {
            var ptr = NativeDll.AllocateArrayOfInt(200);
        }

        [Benchmark]
        public void AllocAndFreeNativeStruct()
        {
            var ptr = NativeDll.AllocateArrayOfPoint(200);
            NativeDll.DeallocateArrayOfPoint(ptr);
        }

        [Benchmark]
        public void AllocNativeStruct()
        {
            var ptr = NativeDll.AllocateArrayOfPoint(200);
        }
    }
}