**Instructions for running the benchmark**
==========================================
To execute the benchmark in linux or mac os
```
cd src/benchmarkDataTableSelectVsLinq
sudo dotnet run -c Release
```
The results are dumped to the screen as well as a benchmark artifacts folder.

See [DataTableSelectVsLinqBenchmark-report-github.md](DataTableSelectVsLinqBenchmark-report-github.md) for an example.

**Troubleshooting**
===================
A test project is included for troubleshooting purposes.

The test can be executed using the following command:
```
cd tests/benchmarkDataTableSelectVsLinq.Tests
dotnet test
```

**License**
===========
| Content | License |
| ------- | ------- |
|Source code|[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)|
|Sample data|[![License: CC BY 4.0](https://img.shields.io/badge/License-CC_BY_4.0-lightgrey.svg)](https://creativecommons.org/licenses/by/4.0/)|

**Attribution**
===============
This repository includes a sample CSV data set that was provided by the government of New Zealand (stats.govt.nz).

See https://www.stats.govt.nz/large-datasets/csv-files-for-download/ for more details.

It is licensed under a 
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg