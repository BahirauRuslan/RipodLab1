namespace Lab1Amdal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonCa = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.textBoxAfrom = new System.Windows.Forms.TextBox();
            this.textBoxAto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNto = new System.Windows.Forms.TextBox();
            this.textBoxNfrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCato = new System.Windows.Forms.TextBox();
            this.textBoxCafrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCtto = new System.Windows.Forms.TextBox();
            this.textBoxCtfrom = new System.Windows.Forms.TextBox();
            this.radioButtonCt = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            this.mainChart.Location = new System.Drawing.Point(13, 13);
            this.mainChart.Name = "mainChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "MainSeries";
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(451, 300);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonCt);
            this.groupBox.Controls.Add(this.radioButtonCa);
            this.groupBox.Controls.Add(this.radioButtonN);
            this.groupBox.Controls.Add(this.radioButtonA);
            this.groupBox.Location = new System.Drawing.Point(473, 139);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(66, 128);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Charts";
            // 
            // radioButtonCa
            // 
            this.radioButtonCa.AutoSize = true;
            this.radioButtonCa.Location = new System.Drawing.Point(7, 68);
            this.radioButtonCa.Name = "radioButtonCa";
            this.radioButtonCa.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCa.TabIndex = 2;
            this.radioButtonCa.Text = "R(ca)";
            this.radioButtonCa.UseVisualStyleBackColor = true;
            this.radioButtonCa.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(7, 44);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(45, 17);
            this.radioButtonN.TabIndex = 1;
            this.radioButtonN.Text = "R(n)";
            this.radioButtonN.UseVisualStyleBackColor = true;
            this.radioButtonN.CheckedChanged += new System.EventHandler(this.radioButtonN_CheckedChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(7, 20);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(45, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.Text = "R(a)";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // textBoxAfrom
            // 
            this.textBoxAfrom.Location = new System.Drawing.Point(516, 30);
            this.textBoxAfrom.Name = "textBoxAfrom";
            this.textBoxAfrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAfrom.TabIndex = 2;
            this.textBoxAfrom.Text = "0";
            // 
            // textBoxAto
            // 
            this.textBoxAto.Location = new System.Drawing.Point(644, 30);
            this.textBoxAto.Name = "textBoxAto";
            this.textBoxAto.Size = new System.Drawing.Size(100, 20);
            this.textBoxAto.TabIndex = 3;
            this.textBoxAto.Text = "0,99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "\'a\' from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "\'n\' from";
            // 
            // textBoxNto
            // 
            this.textBoxNto.Location = new System.Drawing.Point(644, 57);
            this.textBoxNto.Name = "textBoxNto";
            this.textBoxNto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNto.TabIndex = 7;
            this.textBoxNto.Text = "100";
            // 
            // textBoxNfrom
            // 
            this.textBoxNfrom.Location = new System.Drawing.Point(516, 57);
            this.textBoxNfrom.Name = "textBoxNfrom";
            this.textBoxNfrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNfrom.TabIndex = 6;
            this.textBoxNfrom.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "\'ca\' from";
            // 
            // textBoxCato
            // 
            this.textBoxCato.Location = new System.Drawing.Point(644, 83);
            this.textBoxCato.Name = "textBoxCato";
            this.textBoxCato.Size = new System.Drawing.Size(100, 20);
            this.textBoxCato.TabIndex = 11;
            this.textBoxCato.Text = "1";
            // 
            // textBoxCafrom
            // 
            this.textBoxCafrom.Location = new System.Drawing.Point(516, 83);
            this.textBoxCafrom.Name = "textBoxCafrom";
            this.textBoxCafrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxCafrom.TabIndex = 10;
            this.textBoxCafrom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "\'ca\' value";
            // 
            // textBoxCa
            // 
            this.textBoxCa.Location = new System.Drawing.Point(644, 192);
            this.textBoxCa.Name = "textBoxCa";
            this.textBoxCa.Size = new System.Drawing.Size(100, 20);
            this.textBoxCa.TabIndex = 18;
            this.textBoxCa.Text = "1,2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "\'n\' value";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(644, 166);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 16;
            this.textBoxN.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "\'a\' value";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(644, 139);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 14;
            this.textBoxA.Text = "0,5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Step";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(642, 251);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 20;
            this.textBoxStep.Text = "0,01";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(669, 290);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 22;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "to";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "\'ct\' from";
            // 
            // textBoxCtto
            // 
            this.textBoxCtto.Location = new System.Drawing.Point(644, 109);
            this.textBoxCtto.Name = "textBoxCtto";
            this.textBoxCtto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCtto.TabIndex = 24;
            this.textBoxCtto.Text = "1";
            // 
            // textBoxCtfrom
            // 
            this.textBoxCtfrom.Location = new System.Drawing.Point(516, 109);
            this.textBoxCtfrom.Name = "textBoxCtfrom";
            this.textBoxCtfrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxCtfrom.TabIndex = 23;
            this.textBoxCtfrom.Text = "0";
            // 
            // radioButtonCt
            // 
            this.radioButtonCt.AutoSize = true;
            this.radioButtonCt.Location = new System.Drawing.Point(7, 91);
            this.radioButtonCt.Name = "radioButtonCt";
            this.radioButtonCt.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCt.TabIndex = 3;
            this.radioButtonCt.Text = "R(ct)";
            this.radioButtonCt.UseVisualStyleBackColor = true;
            this.radioButtonCt.CheckedChanged += new System.EventHandler(this.radioButtonCt_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "\'ct\' value";
            // 
            // textBoxCt
            // 
            this.textBoxCt.Location = new System.Drawing.Point(644, 218);
            this.textBoxCt.Name = "textBoxCt";
            this.textBoxCt.Size = new System.Drawing.Size(100, 20);
            this.textBoxCt.TabIndex = 27;
            this.textBoxCt.Text = "1,2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 319);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxCt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCtto);
            this.Controls.Add(this.textBoxCtfrom);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCato);
            this.Controls.Add(this.textBoxCafrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNto);
            this.Controls.Add(this.textBoxNfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAto);
            this.Controls.Add(this.textBoxAfrom);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.mainChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonCa;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox textBoxAfrom;
        private System.Windows.Forms.TextBox textBoxAto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNto;
        private System.Windows.Forms.TextBox textBoxNfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCato;
        private System.Windows.Forms.TextBox textBoxCafrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.RadioButton radioButtonCt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCtto;
        private System.Windows.Forms.TextBox textBoxCtfrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCt;
    }
}

