using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApplication2
{
  
    public partial class Class1 : Form1
    {
        public event EventHandler<MoiEventArgs> metoding;
        public Form1 w = new Form1();
        public void w1(string sd)
        {
          //  if (metoding !=null)
                metoding (this, new  MoiEventArgs(sd + "первый метод принял" + "\r\n")); 
           
        }
     
        public string urn = "";
        //public string _return { get { return w2(urn); } }
       
        public Form1 form;

        public void w2(Button sd)
        {
            sd.Enabled = false;

        }


        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {

         
            form = new Form1();
            form.Tag = this;
            form.Show();
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1274, 484);
            this.Name = "Class1";
            this.Load += new System.EventHandler(this.Class1_Load);
            this.ResumeLayout(false);

        }

        private void Class1_Load(object sender, EventArgs e)
        {

        }
    }
    public class MoiEventArgs : EventArgs
    {
        public MoiEventArgs(string msg)
        {
            this.msg = msg;
        }
        public string msg { get;private set; }
        
    }
}
