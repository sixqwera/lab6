using c__перывй_раз_;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt(string message)
        {
            int result;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result; 
                }
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        Console.WriteLine("Введите данные для Lab4:");
        int f1 = ReadInt("Число 1: ");
        int s1 = ReadInt("Число 2: ");
        int t1 = ReadInt("Число 3: ");

        Lab4 obj1 = new Lab4(f1, s1, t1);
        Console.WriteLine("Объект создан: " + obj1.ToString());
        obj1.LastMaxValue();

        Console.WriteLine("--- Проверка копирования ---");
        Lab4 copyObj = new Lab4(obj1);
        Console.WriteLine("Данные копии: " + copyObj.ToString());

        Console.WriteLine("Введите данные для NewLab (4 поля):");
        int nf1 = ReadInt("Число 1: ");
        int ns1 = ReadInt("Число 2: ");
        int nt1 = ReadInt("Число 3: ");
        int nfo = ReadInt("Число 4 (новое): ");

        NewLab childObj = new NewLab(nf1, ns1, nt1, nfo);
        childObj.Sum();
        childObj.Mul();
    }
}