namespace FormMain
{
    /*
     * Завдання 1
Створіть віконний додаток, що генерує набір простих чисел у діапазоні, зазначеному користувачем. Якщо не вказано нижню межу, потік з стартує з 2. Якщо не вказано верхню межу, генерування відбувається до завершення програми. Використовуйте механізм потоків. Числа повинні відображатися у віконному інтерфейсі.
    */
    public static class ThreadNumberTask
    {

        public static void GenerateNumbers(Predicate<long> predicate, EventHandler<EventCreatorEventArgs>? onNumber, long start = 2, long? end = null)
        {
            if (end == null)
            {
                GenerateInfinite(predicate, onNumber, start);
                return;
            }

            for (var i = start; i <= end; i++)
            {
                if (predicate(i))
                {
                    onNumber?.Invoke(null, new EventCreatorEventArgs(i));
                    Thread.Sleep(100);
                }
            }
        }


        private static void GenerateInfinite(Predicate<long> predicate, EventHandler<EventCreatorEventArgs>? onNumber, long number)
        {
            try
            {
                while (true)
                {
                    if (predicate(number))
                    {
                        onNumber?.Invoke(null, new EventCreatorEventArgs(number));
                        Thread.Sleep(100);
                    }
                    number++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//затычка
            }

        }

        public static Predicate<long> IsSimple()
        {
            return number =>
            {
                if (number < 2) return false;
                var sqrt = Math.Sqrt(number);

                for (var i = 2; i <= sqrt; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            };
        }
        public static void GenerateFibonacci(EventHandler<EventCreatorEventArgs>? onNumber, long start, long end)//почему я написала отдельный метод, хотя я сделала метод принимающий делегат? Потому что этот метод работает быстрее на больших числах. 
        {
            try
            {
                long a = 0, b = 1;

                while (a <= end)
                {
                    if (a >= start) onNumber?.Invoke(null, new EventCreatorEventArgs(a));
                    long temp = a + b;
                    a = b;
                    b = temp;
                    Thread.Sleep(100);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//затычка
            }

        }

    }
}
