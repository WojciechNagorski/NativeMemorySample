using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using NativeDllWraper;

namespace NativeMemorySample
{
    [ShortRunJob]
    [NativeMemoryProfiler]
    [MemoryDiagnoser]
    public class IntroNativeMemoryWithRealloc
    {
        [Benchmark]
        public void AllocReallocAndFree()
        {
            // This example uses standard malloc, realloc and free.
            NativeDll.AllocReallocAndFree();
        }

        [Benchmark]
        public void AllocReallocAndFreeUsingVector()
        {
            // This example uses std::vector<int>.
            NativeDll.AllocReallocAndFreeUsingVector();
        }
    }
}