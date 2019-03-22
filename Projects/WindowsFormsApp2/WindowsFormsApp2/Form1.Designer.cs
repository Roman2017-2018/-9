namespace WindowsFormsApp2
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
          
            this.contractTimer = new System.Windows.Forms.Timer(this.components);
            this.expandTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button4
            // 
          
            // 
            // contractTimer
            // 
        
            // 
            // expandTimer
            // 
       
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
          
            this.Name = "Form1";
        
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Timer contractTimer;
        private System.Windows.Forms.Timer expandTimer;
    }
}

