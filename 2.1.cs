using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Настройка отрезка ===");

        double startPoint = Checker.CheckDouble("Введите x: ");
        double endPoint = Checker.CheckDouble("Введите y: ");

        LineSegment mySegment = new LineSegment(
            startPoint, 
            endPoint);

        Console.WriteLine($"Создан {mySegment}");
        Console.WriteLine("=== 2. Проверка операций ===");
        Console.WriteLine($"Длина (!): {!mySegment}");

        mySegment++;
        Console.WriteLine($"После ++: {mySegment}");

        string prompt = "Введите число для проверки (<) " +
            "в диапазоне от -100 до 100: ";

        int checkNum = (int)Checker.CheckDouble(
            prompt, 
            -100, 
            100);

        if (mySegment < checkNum)
        {
            Console.WriteLine($"Число {checkNum} входит.");
        }
        else
        {
            Console.WriteLine($"Число {checkNum} НЕ входит.");
        }

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
