namespace BTL_Prj.Frm.Dashboard
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_doanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_chitieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_chitieu = new System.Windows.Forms.Label();
            this.label_doanhthu = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.lblProfitOrLoss = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_DoanhThu = new System.Windows.Forms.Panel();
            this.panel_ChiTieu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_chitieu)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_chart.SuspendLayout();
            this.panel_DoanhThu.SuspendLayout();
            this.panel_ChiTieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_doanhthu
            // 
            this.chart_doanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_doanhthu.BorderlineColor = System.Drawing.Color.Black;
            this.chart_doanhthu.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart_doanhthu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_doanhthu.Legends.Add(legend1);
            this.chart_doanhthu.Location = new System.Drawing.Point(51, 64);
            this.chart_doanhthu.MaximumSize = new System.Drawing.Size(600, 600);
            this.chart_doanhthu.Name = "chart_doanhthu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_doanhthu.Series.Add(series1);
            this.chart_doanhthu.Size = new System.Drawing.Size(374, 275);
            this.chart_doanhthu.TabIndex = 0;
            this.chart_doanhthu.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart_chitieu
            // 
            this.chart_chitieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_chitieu.BorderlineColor = System.Drawing.Color.Black;
            this.chart_chitieu.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chart_chitieu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_chitieu.Legends.Add(legend2);
            this.chart_chitieu.Location = new System.Drawing.Point(51, 64);
            this.chart_chitieu.MaximumSize = new System.Drawing.Size(600, 600);
            this.chart_chitieu.Name = "chart_chitieu";
            this.chart_chitieu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_chitieu.Series.Add(series2);
            this.chart_chitieu.Size = new System.Drawing.Size(374, 275);
            this.chart_chitieu.TabIndex = 1;
            // 
            // label_chitieu
            // 
            this.label_chitieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_chitieu.BackColor = System.Drawing.Color.Transparent;
            this.label_chitieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chitieu.Location = new System.Drawing.Point(6, 38);
            this.label_chitieu.Name = "label_chitieu";
            this.label_chitieu.Size = new System.Drawing.Size(465, 23);
            this.label_chitieu.TabIndex = 2;
            this.label_chitieu.Text = "Biểu đồ chi tiêu";
            this.label_chitieu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_doanhthu
            // 
            this.label_doanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_doanhthu.BackColor = System.Drawing.Color.Transparent;
            this.label_doanhthu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doanhthu.Location = new System.Drawing.Point(6, 38);
            this.label_doanhthu.Name = "label_doanhthu";
            this.label_doanhthu.Size = new System.Drawing.Size(459, 23);
            this.label_doanhthu.TabIndex = 2;
            this.label_doanhthu.Text = "Biểu đồ doanh thu";
            this.label_doanhthu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(954, 100);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "DASHBOARD";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblProfitOrLoss
            // 
            this.lblProfitOrLoss.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProfitOrLoss.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitOrLoss.Location = new System.Drawing.Point(0, 402);
            this.lblProfitOrLoss.Name = "lblProfitOrLoss";
            this.lblProfitOrLoss.Size = new System.Drawing.Size(954, 23);
            this.lblProfitOrLoss.TabIndex = 4;
            this.lblProfitOrLoss.Text = "laix hay loox";
            this.lblProfitOrLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(954, 100);
            this.panel_title.TabIndex = 5;
            // 
            // panel_chart
            // 
            this.panel_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chart.Controls.Add(this.panel_DoanhThu);
            this.panel_chart.Controls.Add(this.panel_ChiTieu);
            this.panel_chart.Controls.Add(this.lblProfitOrLoss);
            this.panel_chart.Location = new System.Drawing.Point(0, 103);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(954, 425);
            this.panel_chart.TabIndex = 6;
            // 
            // panel_DoanhThu
            // 
            this.panel_DoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.panel_DoanhThu.Controls.Add(this.chart_doanhthu);
            this.panel_DoanhThu.Controls.Add(this.label_doanhthu);
            this.panel_DoanhThu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_DoanhThu.Location = new System.Drawing.Point(477, 0);
            this.panel_DoanhThu.Name = "panel_DoanhThu";
            this.panel_DoanhThu.Size = new System.Drawing.Size(477, 402);
            this.panel_DoanhThu.TabIndex = 7;
            // 
            // panel_ChiTieu
            // 
            this.panel_ChiTieu.BackColor = System.Drawing.Color.Transparent;
            this.panel_ChiTieu.Controls.Add(this.chart_chitieu);
            this.panel_ChiTieu.Controls.Add(this.label_chitieu);
            this.panel_ChiTieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ChiTieu.Location = new System.Drawing.Point(0, 0);
            this.panel_ChiTieu.Name = "panel_ChiTieu";
            this.panel_ChiTieu.Size = new System.Drawing.Size(477, 402);
            this.panel_ChiTieu.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 700);
            this.Controls.Add(this.panel_chart);
            this.Controls.Add(this.panel_title);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.SizeChanged += new System.EventHandler(this.FrmDashboard_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_chitieu)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_chart.ResumeLayout(false);
            this.panel_DoanhThu.ResumeLayout(false);
            this.panel_ChiTieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_doanhthu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_chitieu;
        private System.Windows.Forms.Label label_chitieu;
        private System.Windows.Forms.Label label_doanhthu;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label lblProfitOrLoss;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.Panel panel_DoanhThu;
        private System.Windows.Forms.Panel panel_ChiTieu;
    }
}

