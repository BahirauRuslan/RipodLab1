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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
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
            this.textBoxCto = new System.Windows.Forms.TextBox();
            this.textBoxCfrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea9.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea9);
            this.mainChart.Location = new System.Drawing.Point(13, 13);
            this.mainChart.Name = "mainChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Name = "MainSeries";
            this.mainChart.Series.Add(series9);
            this.mainChart.Size = new System.Drawing.Size(451, 300);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonC);
            this.groupBox.Controls.Add(this.radioButtonN);
            this.groupBox.Controls.Add(this.radioButtonA);
            this.groupBox.Location = new System.Drawing.Point(473, 116);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(66, 96);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Charts";
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
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(7, 68);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(45, 17);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.Text = "R(c)";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
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
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "\'c\' from";
            // 
            // textBoxCto
            // 
            this.textBoxCto.Location = new System.Drawing.Point(644, 83);
            this.textBoxCto.Name = "textBoxCto";
            this.textBoxCto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCto.TabIndex = 11;
            this.textBoxCto.Text = "1";
            // 
            // textBoxCfrom
            // 
            this.textBoxCfrom.Location = new System.Drawing.Point(516, 83);
            this.textBoxCfrom.Name = "textBoxCfrom";
            this.textBoxCfrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxCfrom.TabIndex = 10;
            this.textBoxCfrom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "\'c\' value";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(644, 192);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 18;
            this.textBoxC.Text = "1,2";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 319);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCto);
            this.Controls.Add(this.textBoxCfrom);
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
        private System.Windows.Forms.RadioButton radioButtonC;
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
        private System.Windows.Forms.TextBox textBoxCto;
        private System.Windows.Forms.TextBox textBoxCfrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Button buttonDraw;
    }
}

