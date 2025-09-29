using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuncsWithNumbers
{
    /*Завдання 1
Створіть віконний додаток, що генерує набір простих чисел у діапазоні, зазначеному користувачем. Якщо не вказано нижню межу, потік з стартує з 2. Якщо не вказано верхню межу, генерування відбувається до завершення програми. Використовуйте механізм потоків. Числа повинні відображатися у віконному інтерфейсі.
    */
    public static class NumbersTasks
    {
        private static void Swap(ref long x, ref long y)
        {
            (x, y) = (y, x);
        }
        public static List<long> GenerateNumbers(Predicate<long> delegate_, long start = 2, long end = long.MaxValue)
        {
            if (end < start)
            {
                Swap(ref end, ref start);
            }
            var numbers = new List<long>();
            for (long n = start; n <= end; n++)
            {
                if (delegate_(n)) numbers.Add(n);
            }
            return numbers;
        }

        public static List<long> GenerateNumbers(Predicate<long> delegate_, long end) => GenerateNumbers(delegate_, 2, end);//Якщо не вказано нижню межу, потік з стартує з 2. Я хотіла сперва поставить что бы по умолчанию было значение, но тогда порядок был не логичный
        public static Predicate<long> IsSimple()
        {
            return number =>
            {
                if (number < 2) return false;
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            };
        }
        /*Додайте до першого завдання потік, що генерує набір чисел Фібоначчі. Числа повинні відображатися у віконному інтерфейсі*/
        public static Predicate<long> IsFibonacci()
        {
            return number =>
            {
                if (number < 0) return false;
                long a = 0, b = 1;
                while (b < number)
                {
                    long temp = b;
                    b += a;
                    a = temp;
                }
                return b == number || number == 0;
            };
        }


    }
}

