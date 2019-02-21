using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1Amdal
{
    public class Painter
    {
        private readonly Chart chart;
        private readonly Amdal amdal;


        public Painter(Amdal amdal, Chart chart)
        {
            this.amdal = amdal;
            this.chart = chart;
        }

        public void PaintRA(double aFrom, double aTo, double step)
        {
            if (aFrom > aTo) throw new ArgumentException("AFrom must be less than Ato");
            if (step <= 0) throw new ArgumentException("Step must be more than 0");
            amdal.A = aFrom;
            while (amdal.A <= aTo)
            {
                chart.Series[0].Points.AddXY(amdal.A, amdal.R);
                if (amdal.A + step <= 1)
                {
                    amdal.A += step;
                }
                else
                {
                    break;
                }
            }
        }

        public void PaintRN(int nFrom, int nTo, int step)
        {
            if (nFrom > nTo) throw new ArgumentException("NFrom must be less than Nto");
            if (step <= 0) throw new ArgumentException("Step must be more than 0");
            amdal.N = nFrom;
            while (amdal.N <= nTo)
            {
                chart.Series[0].Points.AddXY(amdal.N, amdal.R);
                amdal.N += step;
            }
        }

        public void PaintRC(double cFrom, double cTo, double step)
        {
            if (cFrom > cTo) throw new ArgumentException("AFrom must be less than Ato");
            if (step <= 0) throw new ArgumentException("Step must be more than 0");
            amdal.C = cFrom;
            while (amdal.C <= cTo)
            {
                chart.Series[0].Points.AddXY(amdal.C, amdal.R);
                amdal.C += step;
            }
        }
    }
}
