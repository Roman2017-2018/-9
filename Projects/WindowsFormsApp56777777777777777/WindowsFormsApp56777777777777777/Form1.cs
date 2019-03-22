using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp56777777777777777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string input = "2)";
            SearchInTxt(input, "риск");
        }


        private void SearchInTxt(string fileLocation, string keyWord)
        {
            string str = File.ReadAllText("text.txt", Encoding.GetEncoding(1251));

            List<string> raw = str.Split(new Char[] { '|'}).ToList();
            List<string> kek = new List<string>();
            raw.RemoveAt(0);
            raw.RemoveAt(10);
            int count1 = 0;
            int temp = 0;
            kek.Add(raw[0]);
            foreach (string s in raw)
            {

                if (temp == 2) {
                   temp = 0;
                    kek.Add(raw[count1]);
                }
                    count1++;
                temp++;
            }
            int c = findKey(kek,keyWord);
            textBox1.Text += c.ToString();
            var result = String.Join("\r\n", kek.ToArray());
            File.WriteAllText("dfdfdfdfdfdfdfdfdfdfdf.txt", result);
        }
        private int findKey(List<string> questions, string key)
        {


            int count = 0;
            int value = 0;
            foreach (string temp in questions)
            {
                ++count;
                List<string> kek = temp.Split(new Char[] { ' ', '.', ',', ':', '\t' }).ToList();
                foreach (string dd in kek)
                {
                    if(dd == key)
                        value++;
                }
                   
            }
            return value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  SearchInTxt("sd", textBox2.Text);
        }
    }
}
