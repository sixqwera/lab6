using System;

namespace c__перывй_раз_
{
    internal class Lab4
    {
        protected int first;
        protected int second;
        protected int third;
        
        public Lab4(int f, int s, int t)
        {
            first = f;
            second = s;
            third = t;
        }

        public Lab4(Lab4 lab4)
        {
            this.first = lab4.first;
            this.second = lab4.second;
            this.third = lab4.third;
        }

        public void LastMaxValue()
        {
            int first1 = first % 10;
            int second1 = second % 10;
            int third1 = third % 10;

            int max = first1;

            if (max < second1)
            {
                max = second1;
            }
            if (max < third1)
            {
                max = third1;
            }
            Console.WriteLine("Максимальное число: " + max);
        }

        public override string ToString()
        {
            return "First: " + first + ", Second: " + second + ", Third: " + third;
        } 
    }

    class NewLab : Lab4
    {
        private int fourth;
        public NewLab(int f, int s, int t, int fo) : base(f, s, t)
        {
            fourth = fo;
        }

        public void Sum()
        {
            int s = first + second + third + fourth;
            Console.WriteLine("Суммма: " + s);
        }

        public void Mul()
        {
            int s = first * second * third * fourth;
            Console.WriteLine("Умножение: " + s);
        }
    }

}
