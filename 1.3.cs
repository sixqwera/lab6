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
        }

        public override string ToString()
        {
            return $"First: {_first}, Second: {_second}, Third: {_third}";
        }
    }
}
