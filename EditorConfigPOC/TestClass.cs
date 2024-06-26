using System.Security.Cryptography;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public class Md5VsSha256
    {
        private const int N = 10000;
        private IEnumerable<double>? data;

        [Benchmark]
        public void IEnumerableListing()
        {
            data = Enumerable.Range(0, N).Select(i => (double)i).Select(SelectMethod);
            var dictionary = new Dictionary<string, string>()
            {
                { "key", JsonSerializer.Serialize(data)}
            };
        }

        private double SelectMethod(double i)
        {
            return i * 2 % 3;
        }
    }
}
