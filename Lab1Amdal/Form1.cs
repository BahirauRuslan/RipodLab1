using System;
using System.Windows.Forms;

namespace Lab1Amdal
{
    public partial class Form1 : Form
    {
        private static string DEFAULT_STEP = "0,01";
        private static string DEFAULT_NSTEP = "1";

        public Form1()
        {
            InitializeComponent();
            radioButtonA.Checked = true;
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                textBoxAfrom.Enabled = true;
                textBoxAto.Enabled = true;
                textBoxNfrom.Enabled = false;
                textBoxNto.Enabled = false;
                textBoxCfrom.Enabled = false;
                textBoxCto.Enabled = false;

                textBoxA.Enabled = false;
                textBoxN.Enabled = true;
                textBoxC.Enabled = true;

                textBoxStep.Text = DEFAULT_STEP;
            }
        }

        private void radioButtonN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonN.Checked)
            {
                textBoxAfrom.Enabled = false;
                textBoxAto.Enabled = false;
                textBoxNfrom.Enabled = true;
                textBoxNto.Enabled = true;
                textBoxCfrom.Enabled = false;
                textBoxCto.Enabled = false;

                textBoxA.Enabled = true;
                textBoxN.Enabled = false;
                textBoxC.Enabled = true;

                textBoxStep.Text = DEFAULT_NSTEP;
            }
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                textBoxAfrom.Enabled = false;
                textBoxAto.Enabled = false;
                textBoxNfrom.Enabled = false;
                textBoxNto.Enabled = false;
                textBoxCfrom.Enabled = true;
                textBoxCto.Enabled = true;

                textBoxA.Enabled = true;
                textBoxN.Enabled = true;
                textBoxC.Enabled = false;

                textBoxStep.Text = DEFAULT_STEP;
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                mainChart.Series[0].Points.Clear();
                Painter painter;
                var amdal = new Amdal();
                if (radioButtonA.Checked)
                {
                    amdal.N = int.Parse(textBoxN.Text);
                    amdal.C = double.Parse(textBoxC.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRA(double.Parse(textBoxAfrom.Text), 
                        double.Parse(textBoxAto.Text), double.Parse(textBoxStep.Text));
                }
                else if (radioButtonN.Checked)
                {
                    amdal.A = double.Parse(textBoxA.Text);
                    amdal.C = double.Parse(textBoxC.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRN(int.Parse(textBoxNfrom.Text),
                        int.Parse(textBoxNto.Text), int.Parse(textBoxStep.Text));
                }
                else if (radioButtonC.Checked)
                {
                    amdal.N = int.Parse(textBoxN.Text);
                    amdal.A = double.Parse(textBoxA.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRC(double.Parse(textBoxCfrom.Text),
                        double.Parse(textBoxCto.Text), double.Parse(textBoxStep.Text));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format of number");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
