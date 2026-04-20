using System;

namespace CSharpLab
{
    public static class Checker
    {
        public static int ReadInt(string message)
        {
            int result;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }
    }
}
