namespace teorver_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputProb = new System.Windows.Forms.TextBox();
            this.labelProb = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelCountIsp = new System.Windows.Forms.Label();
            this.inputCountIsp = new System.Windows.Forms.TextBox();
            this.labelCountSeries = new System.Windows.Forms.Label();
            this.inputCountSeries = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonExe = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputProb
            // 
            this.inputProb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.inputProb.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputProb.Location = new System.Drawing.Point(40, 91);
            this.inputProb.Margin = new System.Windows.Forms.Padding(4);
            this.inputProb.Name = "inputProb";
            this.inputProb.Size = new System.Drawing.Size(157, 28);
            this.inputProb.TabIndex = 0;
            // 
            // labelProb
            // 
            this.labelProb.AutoSize = true;
            this.labelProb.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProb.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelProb.Location = new System.Drawing.Point(36, 56);
            this.labelProb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProb.Name = "labelProb";
            this.labelProb.Size = new System.Drawing.Size(211, 21);
            this.labelProb.TabIndex = 1;
            this.labelProb.Text = "Вероятность события";
            // 
            // labelCountIsp
            // 
            this.labelCountIsp.AutoSize = true;
            this.labelCountIsp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountIsp.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelCountIsp.Location = new System.Drawing.Point(36, 211);
            this.labelCountIsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountIsp.Name = "labelCountIsp";
            this.labelCountIsp.Size = new System.Drawing.Size(245, 21);
            this.labelCountIsp.TabIndex = 3;
            this.labelCountIsp.Text = "Число испытаний в серии";
            // 
            // inputCountIsp
            // 
            this.inputCountIsp.BackColor = System.Drawing.Color.MediumTurquoise;
            this.inputCountIsp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCountIsp.Location = new System.Drawing.Point(40, 248);
            this.inputCountIsp.Margin = new System.Windows.Forms.Padding(4);
            this.inputCountIsp.Name = "inputCountIsp";
            this.inputCountIsp.Size = new System.Drawing.Size(157, 28);
            this.inputCountIsp.TabIndex = 2;
            // 
            // labelCountSeries
            // 
            this.labelCountSeries.AutoSize = true;
            this.labelCountSeries.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountSeries.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelCountSeries.Location = new System.Drawing.Point(36, 366);
            this.labelCountSeries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountSeries.Name = "labelCountSeries";
            this.labelCountSeries.Size = new System.Drawing.Size(175, 21);
            this.labelCountSeries.TabIndex = 5;
            this.labelCountSeries.Text = "Количество серий";
            // 
            // inputCountSeries
            // 
            this.inputCountSeries.BackColor = System.Drawing.Color.MediumTurquoise;
            this.inputCountSeries.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCountSeries.Location = new System.Drawing.Point(40, 405);
            this.inputCountSeries.Margin = new System.Windows.Forms.Padding(4);
            this.inputCountSeries.Name = "inputCountSeries";
            this.inputCountSeries.Size = new System.Drawing.Size(157, 28);
            this.inputCountSeries.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Aquamarine;
            this.chart1.BorderlineColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(506, 56);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Indigo};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(863, 542);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // buttonExe
            // 
            this.buttonExe.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExe.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExe.Location = new System.Drawing.Point(40, 560);
            this.buttonExe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(157, 38);
            this.buttonExe.TabIndex = 7;
            this.buttonExe.Text = "Рассчитать";
            this.buttonExe.UseVisualStyleBackColor = false;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(230, 560);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 38);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1419, 676);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExe);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelCountSeries);
            this.Controls.Add(this.inputCountSeries);
            this.Controls.Add(this.labelCountIsp);
            this.Controls.Add(this.inputCountIsp);
            this.Controls.Add(this.labelProb);
            this.Controls.Add(this.inputProb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputProb;
        private System.Windows.Forms.Label labelProb;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelCountIsp;
        private System.Windows.Forms.TextBox inputCountIsp;
        private System.Windows.Forms.Label labelCountSeries;
        private System.Windows.Forms.TextBox inputCountSeries;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.Button buttonClear;
    }
}

