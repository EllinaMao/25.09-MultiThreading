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
        public static List<int> GenerateNumbers(int start , int end , Predicate<int> delegate_)
        {
            var numbers = new List<int>();
            numbers.AddRange(Enumerable.Range(start , end - start + 1).Where(n => delegate_(n)));

            return numbers;
        }
         public static Predicate<int> IsSimple()
        {
            return number =>
            {
                if (number < 2) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            };
        }
        /*Додайте до першого завдання потік, що генерує набір чисел Фібоначчі. Числа повинні відображатися у віконному інтерфейсі*/
        public static Predicate<int> IsFibonacci()
        {
            return number =>
            {
                if (number < 0) return false;
                int a = 0, b = 1;
                while (b < number)
                {
                    int temp = b;
                    b += a;
                    a = temp;
                }
                return b == number || number == 0;
            };
        }

    }
}

