using NUnit.Framework;

namespace benchmarkDataTableSelectVsLinq.Tests;

public class DataTableSelectVsLinqBenchmarkTests
{
    [TestCase("2002.06")]
    [TestCase("2020.03")]
    [TestCase("1985.12")]
    [TestCase("2001.01")]
    [TestCase("1982.12")]
    public void asd(string period)
    {
        NUnit.Framework.TestContext.Progress.WriteLine($"Given period='{period}'");
        var sut = new DataTableSelectVsLinqBenchmark { Period = period };
        
        var getDataRowsUsingLinqResults = sut.GetDataRowsUsingLinq().Length;
        NUnit.Framework.TestContext.Progress.WriteLine($" - {nameof(sut.GetDataRowsUsingLinq)} returns {getDataRowsUsingLinqResults}");

        var getDataRowsUsingSelectFilterResults = sut.GetDataRowsUsingSelectFilter().Length;
        NUnit.Framework.TestContext.Progress.WriteLine($" - {nameof(sut.GetDataRowsUsingSelectFilter)} returns {getDataRowsUsingSelectFilterResults}");

        Assert.That(getDataRowsUsingLinqResults, Is.EqualTo(getDataRowsUsingSelectFilterResults));
    }
}