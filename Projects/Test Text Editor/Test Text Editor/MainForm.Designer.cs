namespace Test_Text_Editor
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.Content = new System.Windows.Forms.TextBox();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.t = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите фаил";
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(129, 29);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(384, 20);
            this.filePath.TabIndex = 1;
            // 
            // SelectFile
            // 
            this.SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFile.Location = new System.Drawing.Point(533, 27);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 23);
            this.SelectFile.TabIndex = 2;
            this.SelectFile.Text = "Выбрать";
            this.SelectFile.UseVisualStyleBackColor = true;
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile.Location = new System.Drawing.Point(614, 27);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = " Открыть ";
            this.OpenFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(82, 62);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(52, 20);
            this.numFont.TabIndex = 5;
            this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.Location = new System.Drawing.Point(15, 117);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Content.Size = new System.Drawing.Size(674, 350);
            this.Content.TabIndex = 6;
            // 
            // butSaveFile
            // 
            this.butSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveFile.Location = new System.Drawing.Point(614, 473);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(75, 23);
            this.butSaveFile.TabIndex = 7;
            this.butSaveFile.Text = "Сохранить";
            this.butSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.t,
            this.SymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel1.Text = "Колличество символов";
            // 
            // t
            // 
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(0, 17);
            // 
            // SymbolCount
            // 
            this.SymbolCount.Name = "SymbolCount";
            this.SymbolCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 524);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel t;
        private System.Windows.Forms.ToolStripStatusLabel SymbolCount;
    }
}

