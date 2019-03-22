using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
namespace WindowsFormsApplication2
{
    public delegate void cs(string msg,int d);
    public partial class Form1 : Form
    {   /*public  int i;*/
        static public int s = 0; int Gavno = 3;
        private int q { get; set; }
        MyButton mb;
        public int name
        {
            get { return q; }

        }
        public bool MetodDrugogoKlassa(out int peremennaja1)
        {
            peremennaja1 = 1;


            return true;
        }

        public Form1()
        {

             
            InitializeComponent();
            //mb = new MyButton();
            //mb.Text = "My Button";
            //mb.Size = new Size(100, 100);
            //mb.Location = new Point(100, 50);
            //mb.Visible = true;
            //Controls.Add(mb);
            //mb.DoubleClick += new System.EventHandler(this.testdfdjdjdllsflklskfsflk);
            //mb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            //mb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            //mb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
        }
      

        void Method(ref int Gavno)
        {
            Gavno = 9;

        }

















        public
        void button4_Click(object sender,EventArgs e)
        {  
            Class1 sd = new Class1();
           // sd.metoding += new EventHandler<MoiEventArgs>(button1_Click_1);
            //sd.metoding = testdfdjdjdllsflklskfsflk;
            sd.w1("Hello World ");
           // sd.w2(Program.Ui.button4);

        }


        public
         void testdfdjdjdllsflklskfsflk(object ss ,EventArgs e )
        {
            //button1.Top = 10;
            //button1.Left = 10;
            //button1.D
            //button1.Width = 100; button1.Height = 100;
           Program.Ui.richTextBox1.AppendText("ура я хакнул событи ктнопки");
        }
        Point lastPoint;

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               
                button1.Left += e.X - lastPoint.X;
                button1.Top += e.Y - lastPoint.Y;
            }
        }
        private void button1_MouseMove1(object sender, EventArgs e)
        {
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        public class MyButton : Button
        {
            public MyButton()
            {
                SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            }
        }

        private void button1_MouseClick(object sender, MoiEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // невероятно это рабояая кнопка


        //private void button1_Click_1(object sender, MoiEventArgs e)
        //{


        //        Program.Ui.richTextBox1.AppendText(e.msg); 
        //}


        //-----------------------Обобщённые делегаты Action<type> (без выходных параметров )и Funk (с выходными )Funk <type ,type  out>----
        // Action через свойство  public Action<string> metoding { get; set; } в другом классе
        //public
        //void button4_Click(object sender, EventArgs e)
        //{

        //    Class1 sd = new Class1();

        //    sd.metoding = Form1.testdfdjdjdllsflklskfsflk;
        //    sd.w1("Hello World");
        //    // sd.w2(Program.Ui.button4);

        //}
        //static
        // void testdfdjdjdllsflklskfsflk(string msg)
        //{

        //    Program.Ui.richTextBox1.AppendText(msg);
        //}
        //-----------------------Передаём управление элементами в соронний класс-----------------------------------------------------------

        //public
        // void button4_Click(object sender, EventArgs e)
        //{

        //    Class1 sd = new Class1();
        //    new Class1();
        //    cs s = Form1.testdfdjdjdllsflklskfsflk;
        //    sd.w1("Hello World", s);
        //    sd.w2(Program.Ui.button4);

        //}
        //static
        // void testdfdjdjdllsflklskfsflk(string msg)
        //{
        //    Program.Ui.richTextBox1.AppendText(msg);
        //}




        //-----------------------Хух обошёлся бещ this  мучлася 2 дня -----------------------------------------------------------


        //public
        // void button4_Click(object sender, EventArgs e)
        //{

        //    Class1 sd = new Class1();

        //    cs s = Form1.testdfdjdjdllsflklskfsflk;
        //    sd.w1("Hello World", s);
        //}
        //static
        // void testdfdjdjdllsflklskfsflk(string msg)
        //{
        //    Program.ddgg.richTextBox1.AppendText(msg);
        //}




        //-----------------------Передаётся ссылка на текущий экземляр Form1 (именно озда) -----------------------------------------------------------

        //public static Form1 s1;


        //private
        //void button4_Click(object sender, EventArgs e)
        //{
        //    s1 = this;
        //    Class1 sd = new Class1();
        //    cs s = Form1.testdfdjdjdllsflklskfsflk;
        //    sd.w1("Hello World", s);
        //}
        //static
        //void testdfdjdjdllsflklskfsflk(string msg)
        //{
        //    s1.richTextBox1.AppendText(msg);
        //}


        //-----------------Передаётся сам Richtextbox--------------------------------------------------------------
        // private
        //void button4_Click(object sender, EventArgs e)
        // {
        //     //s1 = this;
        //     //Class1 sd = new Class1();
        //     //cs s = Form1.testdfdjdjdllsflklskfsflk;
        //     //sd.w1("Hello World",s);
        //     testdfdjdjdllsflklskfsflk("Привет", this.richTextBox1);

        // }
        // static
        //  void testdfdjdjdllsflklskfsflk(string msg, RichTextBox rico)
        // {



        //     rico.AppendText(msg);

        // }


        //----------------------------------------------------------------------------------------------------

        //    private void button2_Click(object sender, EventArgs e)
        //    {Regex Gcode = new Regex("[gxyzfXYZF][+-]?[0-9]*\\.?[0-9]*");
        //        Match m = Gcode.Match(richTextBox1.Text);

        //        string X = ""; string Y = ""; string Z = ""; string F = "";
        //        while (m.Success)
        //        //for (int i = 0; i<5;i++)  
        //        {


        //            if (m.Value.StartsWith("X"))
        //            {int i=0;
        //                Char gavno = 'X';
        //                Char gavno1 = '.';
        //                string [] Xxs = m.Value.Split(gavno,gavno1);
        //                foreach (var X1 in Xxs)
        //                 i =Int32.Parse(Xxs[1]);
        //                X=Convert.ToString(i/3);

        //                //x = Math.Round(x, 1);

        //                //= Convert.ToString(x);
        //                m = m.NextMatch();
        //            }


        //            if (m.Value.StartsWith("Y"))
        //            {
        //                int i = 0;
        //                Char gavno = 'Y';
        //                Char gavno1 = '.';
        //                string[] Xxs = m.Value.Split(gavno, gavno1);
        //                foreach (var X1 in Xxs)
        //                    i = Int32.Parse(Xxs[1]);
        //                Y= Convert.ToString(i / 3);


        //                m = m.NextMatch();

        //            }

        //            if (m.Value.StartsWith("Z"))
        //            {
        //                int i = 0;
        //                Char gavno = 'Z';
        //                Char gavno1 = '.';
        //                string[] Xxs = m.Value.Split(gavno, gavno1);
        //                foreach (var X1 in Xxs)
        //                    i = Int32.Parse(Xxs[1]);
        //                Z = Convert.ToString(i / 3);

        //                m = m.NextMatch();

        //            }


        //            if (m.Value.StartsWith("F"))
        //            {
        //                F = m.Value;
        //                m = m.NextMatch();

        //            }


        //            richTextBox2.AppendText(X + "\r\n" + Y + "\r\n" + Z + "\r\n" + F + "\r\n");
        //            //StringReader sr = new StringReader(X + Y + Z + F);





        //        }

        //}

        //    private void timer1_Tick(object sender, EventArgs e)
        //    {  timer1.Enabled = true;

        //    }    




    }
}
