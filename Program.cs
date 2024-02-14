using BenchmarkDotNet.Running;


namespace BenchmarkExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }
    }
}