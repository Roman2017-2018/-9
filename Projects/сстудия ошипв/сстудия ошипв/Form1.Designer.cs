namespace сстудия_ошипв
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            lineAnnotation2.AnchorOffsetX = 10D;
            lineAnnotation2.AnchorOffsetY = 10D;
            lineAnnotation2.AxisXName = "ChartArea1\\rX";
            lineAnnotation2.ClipToChartArea = "ChartArea1";
            lineAnnotation2.LineColor = System.Drawing.Color.BlanchedAlmond;
            lineAnnotation2.Name = "LineAnnotation1";
            this.chart1.Annotations.Add(lineAnnotation2);
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Area3DStyle.Inclination = 50;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.PointDepth = 600;
            chartArea2.Area3DStyle.PointGapDepth = 900;
            chartArea2.Area3DStyle.Rotation = 40;
            chartArea2.Area3DStyle.WallWidth = 17;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Interval = 2D;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Bisque;
            chartArea2.AxisX.MajorTickMark.Interval = 1D;
            chartArea2.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea2.AxisX.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.NotSet;
            chartArea2.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.NotSet;
            chartArea2.AxisX.MinorTickMark.IntervalOffset = double.NaN;
            chartArea2.AxisX.MinorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.NotSet;
            chartArea2.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.NotSet;
            chartArea2.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.StripLines.Add(stripLine2);
            chartArea2.AxisX.Title = "Температура °C";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Interval = 0.2D;
            chartArea2.AxisY.MajorGrid.Interval = 0.25D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Bisque;
            chartArea2.AxisY.Title = "Частота (PPM)Гц";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.ToolTip = "hkkk";
            chartArea2.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea2.BackImage = "C:\\Users\\роман\\Desktop\\цук\\0_80bc8_797837ce_XL.jpg";
            chartArea2.CursorY.Interval = 10D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend2.Font = new System.Drawing.Font("Vijaya", 12F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(54, 38);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.PaleGreen;
            series2.CustomProperties = "LineTension=0.5";
            series2.Font = new System.Drawing.Font("Informal Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.MarkerStep = 10;
            series2.Name = "T=F(t)PPM";
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MaxMovingDistance = 40D;
            series2.SmartLabelStyle.MinMovingDistance = 20D;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1301, 696);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title1";
            title2.Text = "                                                                                 " +
    "                                                           ТЧХ";
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1231, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1318, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(342, 27);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 774);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

