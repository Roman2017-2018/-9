namespace microphone
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scottPlotUC3 = new ScottPlot.ScottPlotUC();
            this.scottPlotUC4 = new ScottPlot.ScottPlotUC();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scottPlotUC3
            // 
            this.scottPlotUC3.Location = new System.Drawing.Point(0, 26);
            this.scottPlotUC3.Margin = new System.Windows.Forms.Padding(2);
            this.scottPlotUC3.Name = "scottPlotUC3";
            this.scottPlotUC3.Size = new System.Drawing.Size(640, 191);
            this.scottPlotUC3.TabIndex = 1;
            // 
            // scottPlotUC4
            // 
            this.scottPlotUC4.Location = new System.Drawing.Point(0, 221);
            this.scottPlotUC4.Margin = new System.Windows.Forms.Padding(2);
            this.scottPlotUC4.Name = "scottPlotUC4";
            this.scottPlotUC4.Size = new System.Drawing.Size(640, 191);
            this.scottPlotUC4.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(659, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.scottPlotUC4);
            this.Controls.Add(this.scottPlotUC3);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ScottPlot.ScottPlotUC scottPlotUC1;
        private ScottPlot.ScottPlotUC scottPlotUC2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private ScottPlot.ScottPlotUC scottPlotUC3;
        private ScottPlot.ScottPlotUC scottPlotUC4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
    }
}