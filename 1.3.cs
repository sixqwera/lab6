using System;
using CSharpLab;

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
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        Console.WriteLine("=== Данные для Lab4 ===");
        int f1 = ReadInt("Число 1: ");
        int s1 = ReadInt("Число 2: ");
        int t1 = ReadInt("Число 3: ");

        var obj1 = new Lab4(f1, s1, t1);
        Console.WriteLine($"Объект создан: {obj1}");
        obj1.LastMaxValue();

        Console.WriteLine("\n--- Проверка копирования ---");
        var copyObj = new Lab4(obj1);
        Console.WriteLine($"Данные копии: {copyObj}");

        Console.WriteLine("\n=== Данные для NewLab ===");
        int nf1 = ReadInt("Число 1: ");
        int ns1 = ReadInt("Число 2: ");
        int nt1 = ReadInt("Число 3: ");
        int nfo = ReadInt("Число 4: ");

        var childObj = new NewLab(nf1, ns1, nt1, nfo);

        childObj.Sum(nf1, ns1, nt1);
        childObj.Mul(nf1, ns1, nt1);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
метод внутри метода низя 




using System;

namespace CSharpLab
{
    public class NewLab : Lab4
    {
        private int _fourth;

        public NewLab(int f, int s, int t, int fo) : base(f, s, t)
        {
            _fourth = fo;
        }

        public void Sum(int f, int s, int t)
        {
            int sum = f + s + t + _fourth;
            Console.WriteLine($"Сумма: {sum}");
        }

        public void Mul(int f, int s, int t)
        {
            int mul = f * s * t * _fourth;
            Console.WriteLine($"Умножение: {mul}");
        }
    }
}



using System;

namespace CSharpLab
{
    public class Lab4
    {
        private int _first;
        private int _second;
        private int _third;

        public Lab4(int f, int s, int t)
        {
            _first = f;
            _second = s;
            _third = t;
        }

        public Lab4(Lab4 other)
        {
            _first = other._first;
            _second = other._second;
            _third = other._third;
        }

        public void LastMaxValue()
        {
            int f1 = Math.Abs(_first % 10);
            int s1 = Math.Abs(_second % 10);
            int t1 = Math.Abs(_third % 10);

            int max = f1;
            if (s1 > max) 
            {
                max = s1;
            if (t1 > max) max = t1;

            Console.WriteLine($"Максимальное число: {max}");
        }

        public override string ToString()
        {
            return $"First: {_first}, Second: {_second}, Third: {_third}";
        }
    }
}
