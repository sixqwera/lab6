using System;
using CSharpLab;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Данные для Lab4 ===");

        int f1 = Checker.ReadInt("Число 1: ");
        int s1 = Checker.ReadInt("Число 2: ");
        int t1 = Checker.ReadInt("Число 3: ");

        Lab4 obj1 = new Lab4(f1, s1, t1);
        Console.WriteLine($"Объект создан: {obj1}");
        obj1.LastMaxValue();

        Console.WriteLine("--- Проверка копирования ---");
        Lab4 copyObj = new Lab4(obj1);
        Console.WriteLine($"Данные копии: {copyObj}");

        Console.WriteLine("=== Данные для NewLab ===");
        int nf1 = Checker.ReadInt("Число 1: ");
        int ns1 = Checker.ReadInt("Число 2: ");
        int nt1 = Checker.ReadInt("Число 3: ");
        int nfo = Checker.ReadInt("Число 4: ");

        NewLab childObj = new NewLab(nf1, ns1, nt1, nfo);
        childObj.Sum(nf1, ns1, nt1);
        childObj.Mul(nf1, ns1, nt1);
    }
}
