using System;

namespace Lab1Amdal
{
    public class Amdal
    {
        private double a;
        private double ca;
        private double ct;
        private int n;

        public Amdal() { }

        public Amdal(double a, double ca, double ct, int n)
        {
            A = a;
            Ca = ca;
            Ct = ct;
            N = n;
        }

        public double R
        {
            get
            {
                return 1 / (a + ((1 - a) / n) + ca*ct);
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
                    throw new ArgumentException("\'a\' should be more than(or equal) 0 and less(or equal) than 1");
                }
            }
        }

        public double Ca
        {
            get
            {
                return ca;
            }

            set
            {
                if (value >= 0)
                {
                    ca = value;
                }
                else
                {
                    throw new ArgumentException("\'Ca\' should be more than(or equal) 0");
                }
            }
        }

        public double Ct
        {
            get
            {
                return ct;
            }

            set
            {
                if (value >= 0)
                {
                    ct = value;
                }
                else
                {
                    throw new ArgumentException("\'Ct\' should be more than(or equal) 0");
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
                    throw new ArgumentException("\'n\' should be more than 0");
                }
            }
        }
    }
}
