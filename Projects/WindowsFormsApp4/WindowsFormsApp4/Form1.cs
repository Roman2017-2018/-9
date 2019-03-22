using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {   

        public string fs = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox2.Text;
            HuffmanTree huffmanTree = new HuffmanTree();

            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encode
            BitArray encoded1 = huffmanTree.Encode1(input);
            string decoded2 = huffmanTree.Decode(encoded1);
            richTextBox1.AppendText("переведённое значение: ");
            foreach (bool bit in encoded1)
            {
                richTextBox1.AppendText((bit ? 1 : 0) + "");
            }
            richTextBox1.AppendText("\r\n" );
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++) { 
                BitArray encoded = huffmanTree.Encode(arr[i]);
               string decoded = huffmanTree.Decode(encoded);
                if (i == 0) { richTextBox1.AppendText(decoded + "="); }
                else { richTextBox1.AppendText("\r\n" + decoded + "="); }
            foreach (bool bit in encoded) 
            {
                 richTextBox1.AppendText((bit ? 1 : 0) + "");
            }
           }
            // Decode








            //// Build the Huffman tree


            //// Encode

            //richTextBox1.AppendText("Encoded: ");




            //// Decode
            //string decoded = huffmanTree.Decode(encoded);

            //richTextBox1.AppendText("Decoded: " + decoded);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); richTextBox2.Clear();
        }
    }
}

