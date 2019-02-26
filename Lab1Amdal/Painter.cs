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

        public void PaintRCa(double caFrom, double caTo, double step)
        {
            if (caFrom > caTo) throw new ArgumentException("CaFrom must be less than Cato");
            if (step <= 0) throw new ArgumentException("Step must be more than 0");
            amdal.Ca = caFrom;
            while (amdal.Ca <= caTo)
            {
                chart.Series[0].Points.AddXY(amdal.Ca, amdal.R);
                amdal.Ca += step;
            }
        }

        public void PaintRCt(double ctFrom, double ctTo, double step)
        {
            if (ctFrom > ctTo) throw new ArgumentException("CtFrom must be less than Ctto");
            if (step <= 0) throw new ArgumentException("Step must be more than 0");
            amdal.Ct = ctFrom;
            while (amdal.Ct <= ctTo)
            {
                chart.Series[0].Points.AddXY(amdal.Ct, amdal.R);
                amdal.Ct += step;
            }
        }
    }
}
