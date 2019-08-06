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
 │  ├─AllocAndFreeManyType          
 │  ├─AllocAndFreeNativeInt         
 │  ├─AllocNativeInt                
 │  ├─AllocAndFreeNativeStruct      
 │  └─AllocNativeStruct             
 └─IntroNativeMemoryWithRealloc     
    ├─AllocReallocAndFree           
    └─AllocReallocAndFreeUsingVector
```
