# NativeMemorySample
Analyzing native memory allocation with BenchmarkDotNet.

In this repo you can find benchmarks that are examples of using `NativeMemoryProfiler`. There is a list of all benchmarks:

```ini
NativeMemorySample
 ├─IntroBitmap
 │  ├─BitmapWithLeaks
 │  └─Bitmap
 ├─IntroNativeMemory
 │  ├─AllocHGlobal
 │  └─AllocHGlobalWithLeaks
 ├─IntroNativeMemoryFromNativeDll
 │  ├─AllocManyType
 │  ├─AllocAndFreeNativeInt
 │  ├─AllocNativeInt
 │  ├─AllocAndFreeNativeStruct
 │  └─AllocNativeStruct
 ├─IntroNativeMemoryWithRealloc
 │  ├─AllocReallocAndFree
 │  └─AllocReallocAndFreeUsingVector
 └─IntroStackTrace
    └─StackTrace
```

Run benchmarks for .Net Framework 4.7.2:
```
dotnet run -c Release -f net472 -- --filter *
```

Run tests for .Net Core 3.1:
```
dotnet run -c Release -f netcoreapp3.1 -- --filter *
```

Run benchmarks with only one invocation of the benchmarked function

```
dotnet run -c Release -f netcoreapp3.1 -- --filter * --launchCount 1 --iterationCount 1 --invocationCount 1 --unrollFactor 1
```