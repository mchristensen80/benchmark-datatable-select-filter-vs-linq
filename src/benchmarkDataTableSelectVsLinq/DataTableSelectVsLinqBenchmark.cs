using BenchmarkDotNet.Attributes;
using CsvHelper;
using System.Data;
using System.Globalization;

[MemoryDiagnoser]
public class DataTableSelectVsLinqBenchmark
{
    [Params("2002.06", "2020.03", "1985.12", "2001.01", "1982.12")]
    public string? Period { get; set; }

    [Benchmark]
    public DataRow[] GetDataRowsUsingSelectFilter()
    {
        var dataTable = CreateSampleDataTable();

        return dataTable.Select($"Period = '{Period}'");
    }

    [Benchmark]
    public DataRow[] GetDataRowsUsingLinq()
    {
        var dataTable = CreateSampleDataTable();

        return dataTable.AsEnumerable()
            .Where(row => row.Field<string>("Period") == Period)
            .ToArray();
    }

    private static DataTable CreateSampleDataTable()
    {
        using (var reader = new StreamReader("sampleData/business-price-indexes-march-2022-quarter-csv.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            using (var dr = new CsvDataReader(csv))
            {		
                var dt = new DataTable();
                dt.Load(dr);

                return dt;
            }
        }
    }
}