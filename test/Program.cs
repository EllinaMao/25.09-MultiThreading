using FuncsWithNumbers;

namespace test
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> num = NumbersTasks.GenerateNumbers(NumbersTasks.IsFibonacci(), 100);
            foreach (var item in num)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }
        }
    }
}
