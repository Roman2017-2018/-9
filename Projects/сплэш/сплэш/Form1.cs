using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сплэш
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 2;
            if(rectangleShape2.Width >=665)
            {
                timer1.Stop();
                    MessageBox.Show("ЧПУ Готов");
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
        }
    }

    

}




