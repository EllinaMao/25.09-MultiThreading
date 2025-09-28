using FuncsWithNumbers;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = NumbersTasks.GenerateNumbers(1, 100, NumbersTasks.IsFibonacci());
            foreach (var item in num)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }
        }
    }
}
