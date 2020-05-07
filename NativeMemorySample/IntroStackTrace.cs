using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace NativeMemorySample
{
    [ShortRunJob]
    [NativeMemoryProfiler]
    [MemoryDiagnoser]
    public class IntroStackTrace
    {

        [Benchmark]
        public string StackTrace()
        {
            var stackTrace = new StackTrace();

            return stackTrace.GetType().Name;
        }
    }
}