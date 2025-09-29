using System.Numerics;

namespace FormMain
{
    /*
     * Завдання 1
Створіть віконний додаток, що генерує набір простих чисел у діапазоні, зазначеному користувачем. Якщо не вказано нижню межу, потік з стартує з 2. Якщо не вказано верхню межу, генерування відбувається до завершення програми. Використовуйте механізм потоків. Числа повинні відображатися у віконному інтерфейсі.
    */
    public static class ThreadNumberTask
    {

        public static void GenerateNumbers(Predicate<BigInteger> predicate, EventHandler<EventCreatorEventArgs>? onNumber, BigInteger start, BigInteger? end = null, ControlTokens? tokens = null)
        {
            var n = start;
            while (end == null || n <= end)
            {
                tokens?.Token.ThrowIfCancellationRequested();
                tokens?.WaitIfPaused();
                if (predicate(n))
                {
                    onNumber?.Invoke(null, new EventCreatorEventArgs(n));
                    Thread.Sleep(1000);
                }

                n++;
            }
        }

        public static Predicate<BigInteger> IsSimple()
        {
            return number =>
            {
                if (number < 2) return false;
                if (number == 2 || number == 3) return true;
                if (number % 2 == 0) return false;

                BigInteger i = 3;
                while (i * i <= number)
                {
                    if (number % i == 0) return false;
                    i += 2;
                }
                return true;
            };
        }

        public static void GenerateFibonacci(EventHandler<EventCreatorEventArgs>? onNumber, BigInteger start, BigInteger? end = null, ControlTokens? tokens = null)
        {
            try
            {
                BigInteger a = 0;
                BigInteger b = 1;

                while (end == null || a <= end)
                {
                    tokens?.Token.ThrowIfCancellationRequested();
                    tokens?.WaitIfPaused();
                    if (a >= start)
                    {
                        onNumber?.Invoke(null, new EventCreatorEventArgs(a));
                        Thread.Sleep(800);
                    }
                    var temp = a + b;
                    a = b;
                    b = temp;
   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
