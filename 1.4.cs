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
