using System;

namespace Lab1Amdal
{
    public class Amdal
    {
        private double a;
        private double c;
        private int n;

        public Amdal() { }

        public Amdal(double a, double c, int n)
        {
            A = a;
            C = c;
            N = n;
        }

        public double R
        {
            get
            {
                return 1 / (a + ((1 - a) / n) + c);
            }
        }

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                if (value >= 0 && value <= 1)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                if (value >= 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int N
        {
            get
            {
                return n;
            }

            set
            {
                if (value > 0)
                {
                    n = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
