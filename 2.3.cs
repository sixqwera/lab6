namespace ConsoleApp1

{
    internal class Checker
    {
        public static double CheckDouble(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }

                Console.Write("Ошибка! Введите число. " +
                    "Повторите: ");
            }
        }

        public static double CheckDouble(
            string prompt,
            double min,
            double max)
        {
            Console.Write(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                bool isDouble = double.TryParse(
                    input,
                    out double result);
                if (isDouble && result >= min && result <= max)
                {
                    return result;
                }

                Console.Write($"Ошибка! Введите число " +
                    $"от {min} до {max}: ");
            }
        }
    }
}
