namespace FinalProject
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_gentext = new System.Windows.Forms.Button();
            this.groupBox_gentext = new System.Windows.Forms.GroupBox();
            this.numericUpDownRounds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDataSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_total_time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox_log = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_gentext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total_time)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gentext
            // 
            this.button_gentext.Location = new System.Drawing.Point(139, 532);
            this.button_gentext.Name = "button_gentext";
            this.button_gentext.Size = new System.Drawing.Size(79, 23);
            this.button_gentext.TabIndex = 1;
            this.button_gentext.Text = "Generate";
            this.button_gentext.UseVisualStyleBackColor = true;
            this.button_gentext.Click += new System.EventHandler(this.button_gentext_Click);
            // 
            // groupBox_gentext
            // 
            this.groupBox_gentext.Controls.Add(this.label6);
            this.groupBox_gentext.Controls.Add(this.numericUpDownRounds);
            this.groupBox_gentext.Controls.Add(this.label5);
            this.groupBox_gentext.Controls.Add(this.label4);
            this.groupBox_gentext.Controls.Add(this.numericUpDownDataSize);
            this.groupBox_gentext.Controls.Add(this.button_gentext);
            this.groupBox_gentext.Controls.Add(this.label3);
            this.groupBox_gentext.Controls.Add(this.label2);
            this.groupBox_gentext.Controls.Add(this.label1);
            this.groupBox_gentext.Location = new System.Drawing.Point(12, 12);
            this.groupBox_gentext.Name = "groupBox_gentext";
            this.groupBox_gentext.Size = new System.Drawing.Size(251, 583);
            this.groupBox_gentext.TabIndex = 2;
            this.groupBox_gentext.TabStop = false;
            this.groupBox_gentext.Text = "Generate Text";
            // 
            // numericUpDownRounds
            // 
            this.numericUpDownRounds.Location = new System.Drawing.Point(98, 46);
            this.numericUpDownRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRounds.Name = "numericUpDownRounds";
            this.numericUpDownRounds.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRounds.TabIndex = 17;
            this.numericUpDownRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "MD5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tripple DES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownDataSize
            // 
            this.numericUpDownDataSize.Location = new System.Drawing.Point(98, 19);
            this.numericUpDownDataSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDataSize.Name = "numericUpDownDataSize";
            this.numericUpDownDataSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDataSize.TabIndex = 7;
            this.numericUpDownDataSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "AES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rounds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Size (MB)";
            // 
            // chart_total_time
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_total_time.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_total_time.Legends.Add(legend4);
            this.chart_total_time.Location = new System.Drawing.Point(283, 12);
            this.chart_total_time.Name = "chart_total_time";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_total_time.Series.Add(series4);
            this.chart_total_time.Size = new System.Drawing.Size(683, 284);
            this.chart_total_time.TabIndex = 3;
            this.chart_total_time.Text = "chart1";
            // 
            // listBox_log
            // 
            this.listBox_log.FormattingEnabled = true;
            this.listBox_log.Location = new System.Drawing.Point(283, 302);
            this.listBox_log.Name = "listBox_log";
            this.listBox_log.Size = new System.Drawing.Size(683, 303);
            this.listBox_log.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SHA1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 618);
            this.Controls.Add(this.listBox_log);
            this.Controls.Add(this.chart_total_time);
            this.Controls.Add(this.groupBox_gentext);
            this.Name = "FormMain";
            this.Text = "Encryption Performance Test";
            this.groupBox_gentext.ResumeLayout(false);
            this.groupBox_gentext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total_time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_gentext;
        private System.Windows.Forms.GroupBox groupBox_gentext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDataSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRounds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_total_time;
        private System.Windows.Forms.ListBox listBox_log;
        private System.Windows.Forms.Label label6;
    }
}

