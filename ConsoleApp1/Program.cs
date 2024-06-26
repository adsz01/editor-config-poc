using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using EditorConfigPOC;
using MyBenchmarks;
using SB.Community.Serialisation.Interfaces;
using SB.Customer.Management.Common.Application.Repositories;
using System.IO.Compression;
using System.Text;

var bmRep = new BrandManagementRepository(new SB.Community.Serialisation.NewtonsoftJson.NewtonsoftJsonSerialiser());

await bmRep.GetDefaultBrandExternalEntityAsync("dce5427e-f7f7-41f5-8fb8-8cdcf463541b");

static string DecompressString(string compressedString)
{
    byte[] decompressedBytes;

    var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));

    string responseContent;
    using (var brotli = new BrotliStream(compressedStream, System.IO.Compression.CompressionMode.Decompress, true))
    {
        var streamReader = new StreamReader(brotli);
        responseContent = streamReader.ReadToEnd();
    }

    return responseContent;
}

string output = DecompressString("Gx4BAMTK/XzlV+c6AXyynx2BC5bZMQ4cRlj0VpxgXEgGj+G7foekH15wt1hPl59ZzF8KOoiYbVOmkq+iktZNUsq1khTGBa9rMyqB4Wk3KujQgjO8KEcmcU06e0G+CEVOpOJNSJlHA4bP0axutnG2RAfJpSauSJpPwTstOsl7QXsptf8Hw+PouN2ta56mkfFfuX8eyvz18Rkf3x/b80P0b2B4ndNPb7dQtwyv68V+VOr6paAzDK/TuG2L9eyloBMMH9t1jbPP07KiU6CGoJ0S1mmDGw==");

List<int> variable1 = null;

IEnumerable<int> numbers = new List<int>()
{
    1,
    2,
    3,
    4,
    5,
    6,
};

var stringNumbers = numbers.Where(x => x % 2 == 0).Select(x => x / 2);
var stringNumbers2 = numbers.Where(x => x % 2 == 0).Select(x => x / 2);
var stringNumbers3 = numbers.Where(x => x % 2 == 0).Select(x => x / 2);

//Console.WriteLine(string.Join(",", numbers.Where(x => x % 2 == 0)));
//Console.WriteLine(string.Join(",", stringNumbers2.Where(x => x % 2 == 0)));
//Console.WriteLine(string.Join(",", stringNumbers2.Where(x => x % 2 == 0)));

var odds = numbers.Where(x => x % 2 == 0);
MyMethod(stringNumbers2);

BenchmarkRunner.Run<Md5VsSha256>();

return;

DateTime MapDateTime(string timeStamp)
 => DateTime.TryParse(timeStamp, out var dateTime) ? dateTime : DateTime.Now;

[Benchmark]
void MyMethod(IEnumerable<int> input)
{
    var someStrings = GetStrings().Select(i => string.Concat("Hello"));

    var count = someStrings.Count();
    var lastElement = someStrings.Last();
}

IEnumerable<string> GetStrings()
    => new List<int>()
        {
            1,
            2,
            3,
            4,
            5,
            6,
        }.Select(i => i.ToString());

class Testclass
{
    public int var1 { get; set; }
}

