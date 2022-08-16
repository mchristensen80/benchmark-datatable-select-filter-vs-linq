``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.5 (21G72) [Darwin 21.6.0]
Intel Core i5-9600K CPU 3.70GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|                       Method |  Period |     Mean |   Error |   StdDev |   Median |      Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|----------------------------- |-------- |---------:|--------:|---------:|---------:|-----------:|----------:|----------:|----------:|
| **GetDataRowsUsingSelectFilter** | **1982.12** | **346.0 ms** | **3.01 ms** |  **2.82 ms** | **345.7 ms** |  **8000.0000** | **3000.0000** |         **-** |     **74 MB** |
|         GetDataRowsUsingLinq | 1982.12 | 276.0 ms | 1.89 ms |  1.77 ms | 276.7 ms |  7000.0000 | 2000.0000 |         - |     72 MB |
| **GetDataRowsUsingSelectFilter** | **1985.12** | **348.0 ms** | **2.79 ms** |  **2.47 ms** | **347.4 ms** |  **8000.0000** | **3000.0000** |         **-** |     **74 MB** |
|         GetDataRowsUsingLinq | 1985.12 | 282.9 ms | 3.23 ms |  3.02 ms | 282.5 ms |  7000.0000 | 2000.0000 |         - |     72 MB |
| **GetDataRowsUsingSelectFilter** | **2001.01** | **337.0 ms** | **4.85 ms** |  **4.54 ms** | **336.2 ms** | **11000.0000** | **6000.0000** | **3000.0000** |     **74 MB** |
|         GetDataRowsUsingLinq | 2001.01 | 280.0 ms | 2.07 ms |  1.84 ms | 280.4 ms |  9000.0000 | 5000.0000 | 2000.0000 |     72 MB |
| **GetDataRowsUsingSelectFilter** | **2002.06** | **350.5 ms** | **6.97 ms** | **12.21 ms** | **344.2 ms** |  **8000.0000** | **3000.0000** |         **-** |     **74 MB** |
|         GetDataRowsUsingLinq | 2002.06 | 284.3 ms | 2.24 ms |  2.09 ms | 284.4 ms |  7000.0000 | 2000.0000 |         - |     72 MB |
| **GetDataRowsUsingSelectFilter** | **2020.03** | **341.8 ms** | **1.94 ms** |  **1.51 ms** | **342.3 ms** |  **8000.0000** | **3000.0000** |         **-** |     **74 MB** |
|         GetDataRowsUsingLinq | 2020.03 | 277.7 ms | 1.75 ms |  1.64 ms | 277.8 ms |  7000.0000 | 2000.0000 |         - |     72 MB |
