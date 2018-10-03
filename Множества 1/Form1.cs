using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Множества_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StoreColLection collection = new StoreColLection(@"Text.txt");
            //collection.Add(2018);
          // collection.Add(55);                                 Привет первый коммит всё работает
            collection.Remove(56);
            foreach (int i in collection)
            {
                richTextBox1.Text += i.ToString() + " ";
            }
        }
    }

    public class StoreColLection : ICollection<int>
    {
        private readonly string _filePath;

        public StoreColLection(string filePath)
        {
            _filePath = filePath;
        }

        private string [] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);
            string [] numbers = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries );
            return numbers;
        }

        public int Count
        {
            get
            {
                string[] numbers = GetNumbers();
                return numbers.Length;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        //void ICollection<int>.Add(int item) 
     
         public void Add(int item)
        {
            string[] numbers = GetNumbers();
            if (numbers.Length == 0)
                File.WriteAllText(_filePath, item.ToString());
            else
                File.AppendAllText(_filePath,"," + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filePath," ");
        }

        public bool Contains(int item)
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                    return true;
            }
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                array[arrayIndex] = Int32.Parse(number);
                arrayIndex++;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            string [] numbers = GetNumbers();

            foreach (string number in numbers)
            {
                yield return Int32.Parse(number);
            }
        }

        public bool Remove(int item)
        {
            string[] numbers = GetNumbers();
            string line = File.ReadAllText(_filePath);

            int SymbolPosition = 0;

            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                {
                    if (numbers.Length == 1)
                    {
                        line = " ";
                    }
                    else if (SymbolPosition == 0)
                    {
                        line = line.Substring(SymbolPosition + number.Length + 1);
                    }
                    else
                    {
                        line = line.Remove(SymbolPosition - 1, number.Length + 1);
                    }
                    File.WriteAllText(_filePath, line);
                    return true;
                }
                SymbolPosition += number.Length + 1;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
