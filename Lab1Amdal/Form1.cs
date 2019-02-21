using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Amdal
{
    public partial class Form1 : Form
    {
        private static string DEFAULT_STEP = "0.01";
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
    }
}
