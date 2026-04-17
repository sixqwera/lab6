using c__перывй_раз_;
using System;

class Program
{
    static void Main(string[] args)
    {
        double ReadDouble(string message)
        {
            double result;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка! Введите числовое значение.");
            }
        }

        Console.WriteLine("=== Настройка отрезка ===");
        double startPoint = ReadDouble("Введите координату начала (x): ");
        double endPoint = ReadDouble("Введите координату конца (y): ");

        LineSegment mySegment = new LineSegment(startPoint, endPoint);
        Console.WriteLine("Создан " + mySegment.ToString());

        Console.WriteLine("=== Проверка точки ===");
        double checkNum = ReadDouble("Введите число для проверки: ");

        if (mySegment.IsInside(checkNum))
        {
            Console.WriteLine("Результат: True (Число входит в отрезок)");
        }
        else
        {
            Console.WriteLine("Результат: False (Число НЕ входит в отрезок)");
        }

        LineSegment copySegment = new LineSegment(mySegment);
        Console.WriteLine("Создана копия отрезка: " + copySegment.ToString());
    }
}

