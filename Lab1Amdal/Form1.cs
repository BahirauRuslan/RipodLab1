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
                textBoxCafrom.Enabled = false;
                textBoxCato.Enabled = false;
                textBoxCtfrom.Enabled = false;
                textBoxCtto.Enabled = false;

                textBoxA.Enabled = false;
                textBoxN.Enabled = true;
                textBoxCa.Enabled = true;
                textBoxCt.Enabled = true;

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
                textBoxCafrom.Enabled = false;
                textBoxCato.Enabled = false;
                textBoxCtfrom.Enabled = false;
                textBoxCtto.Enabled = false;

                textBoxA.Enabled = true;
                textBoxN.Enabled = false;
                textBoxCa.Enabled = true;
                textBoxCt.Enabled = true;

                textBoxStep.Text = DEFAULT_NSTEP;
            }
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCa.Checked)
            {
                textBoxAfrom.Enabled = false;
                textBoxAto.Enabled = false;
                textBoxNfrom.Enabled = false;
                textBoxNto.Enabled = false;
                textBoxCafrom.Enabled = true;
                textBoxCato.Enabled = true;
                textBoxCtfrom.Enabled = false;
                textBoxCtto.Enabled = false;

                textBoxA.Enabled = true;
                textBoxN.Enabled = true;
                textBoxCa.Enabled = false;
                textBoxCt.Enabled = true;

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
                    amdal.Ca = double.Parse(textBoxCa.Text);
                    amdal.Ct = double.Parse(textBoxCt.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRA(double.Parse(textBoxAfrom.Text), 
                        double.Parse(textBoxAto.Text), double.Parse(textBoxStep.Text));
                }
                else if (radioButtonN.Checked)
                {
                    amdal.A = double.Parse(textBoxA.Text);
                    amdal.Ca = double.Parse(textBoxCa.Text);
                    amdal.Ct = double.Parse(textBoxCt.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRN(int.Parse(textBoxNfrom.Text),
                        int.Parse(textBoxNto.Text), int.Parse(textBoxStep.Text));
                }
                else if (radioButtonCa.Checked)
                {
                    amdal.N = int.Parse(textBoxN.Text);
                    amdal.A = double.Parse(textBoxA.Text);
                    amdal.Ct = double.Parse(textBoxCt.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRCa(double.Parse(textBoxCafrom.Text),
                        double.Parse(textBoxCato.Text), double.Parse(textBoxStep.Text));
                }
                else if (radioButtonCt.Checked)
                {
                    amdal.N = int.Parse(textBoxN.Text);
                    amdal.A = double.Parse(textBoxA.Text);
                    amdal.Ca = double.Parse(textBoxCa.Text);
                    painter = new Painter(amdal, mainChart);
                    painter.PaintRCt(double.Parse(textBoxCtfrom.Text),
                        double.Parse(textBoxCtto.Text), double.Parse(textBoxStep.Text));
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

        private void radioButtonCt_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAfrom.Enabled = false;
            textBoxAto.Enabled = false;
            textBoxNfrom.Enabled = false;
            textBoxNto.Enabled = false;
            textBoxCafrom.Enabled = false;
            textBoxCato.Enabled = false;
            textBoxCtfrom.Enabled = true;
            textBoxCtto.Enabled = true;

            textBoxA.Enabled = true;
            textBoxN.Enabled = true;
            textBoxCa.Enabled = true;
            textBoxCt.Enabled = false;

            textBoxStep.Text = DEFAULT_STEP;
        }
    }
}
