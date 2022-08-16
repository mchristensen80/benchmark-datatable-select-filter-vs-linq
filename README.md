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

**Attribution**
===============
My sample data set is an unmodified version of a CSV data set that is provided by the government of New Zealand (stats.govt.nz).

It is licensed for re-use under a Creative Commons 4.0 International Licence.

See https://www.stats.govt.nz/large-datasets/csv-files-for-download/ for more details.