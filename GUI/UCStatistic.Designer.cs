namespace QuanLyBanHang.GUI
{
    partial class UCStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnByDay = new System.Windows.Forms.Button();
            this.btnByMonth = new System.Windows.Forms.Button();
            this.btnByYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Tổng nhập";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Tổng thu";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Tổng lãi";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(828, 717);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnByDay
            // 
            this.btnByDay.Location = new System.Drawing.Point(697, 133);
            this.btnByDay.Name = "btnByDay";
            this.btnByDay.Size = new System.Drawing.Size(124, 52);
            this.btnByDay.TabIndex = 1;
            this.btnByDay.Text = "Theo ngày trong tháng";
            this.btnByDay.UseVisualStyleBackColor = true;
            this.btnByDay.Click += new System.EventHandler(this.btnByDay_Click);
            // 
            // btnByMonth
            // 
            this.btnByMonth.Location = new System.Drawing.Point(695, 191);
            this.btnByMonth.Name = "btnByMonth";
            this.btnByMonth.Size = new System.Drawing.Size(124, 52);
            this.btnByMonth.TabIndex = 1;
            this.btnByMonth.Text = "Theo tháng";
            this.btnByMonth.UseVisualStyleBackColor = true;
            this.btnByMonth.Click += new System.EventHandler(this.btnByMonth_Click);
            // 
            // btnByYear
            // 
            this.btnByYear.Location = new System.Drawing.Point(696, 249);
            this.btnByYear.Name = "btnByYear";
            this.btnByYear.Size = new System.Drawing.Size(124, 52);
            this.btnByYear.TabIndex = 1;
            this.btnByYear.Text = "Theo năm";
            this.btnByYear.UseVisualStyleBackColor = true;
            this.btnByYear.Click += new System.EventHandler(this.btnByYear_Click);
            // 
            // UCStatistic
            // 
            this.AccessibleDescription = "Thống kê";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnByYear);
            this.Controls.Add(this.btnByMonth);
            this.Controls.Add(this.btnByDay);
            this.Controls.Add(this.chart1);
            this.Name = "UCStatistic";
            this.Size = new System.Drawing.Size(828, 717);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnByDay;
        private System.Windows.Forms.Button btnByMonth;
        private System.Windows.Forms.Button btnByYear;
    }
}
