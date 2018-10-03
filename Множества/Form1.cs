using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Множества_1;
namespace Множества
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Progression progression = new Progression(109);
            if (false)richTextBox1.Text += "Игорь";richTextBox1.Text += "Игорь";
                
              
            

            foreach (int i in progression)
            {
                richTextBox1.Text += i.ToString();
            }
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(26);
            lst.Remove(26);
            richTextBox1.Text +=lst.Count;

            Dictionary<int, Person> person = new Dictionary<int, Person>();
            Person person1 = new Person() {Id=1,Name="Игорь" };
            Person person2 = new Person() { Id = 2, Name = "Михаил" };
            person.Add(person1.Id, person1);
            person.Add(person2.Id, person2);
            Person searchPerson;
            bool isExist = person.TryGetValue(2,out searchPerson);
            if (isExist)
                richTextBox1.Text += searchPerson.Name;
            int[] arr = new int[5];
            IList<int> lst1 = arr;
            // lst1.Add(1);
            StoreColLection collection = new StoreColLection(@"Text.txt");
            collection.Add(2018);
            
        }




    }
    public class Person
    {
        public int Id { get; set; }
        public string  Name { get; set; }

    }
    public class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }
        public IEnumerator<int> GetEnumerator()
        { 
            //"синтаксический сахар" yield return  он заменяет   итервейс IEnumerator 
            int current = 1;
            for (int i = 0; i < _itemCount - 101; i++)
            {
                if (i == 0) yield return 1;
                current += 3;
                yield return current;
            }

   
          //  return new ProgressionIterator(_itemCount);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _current;
        private int _position;

        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }

        public int Current
        {
            get { return _current; }
        }

        object IEnumerator.Current
        {

            get { return Current; }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (_position > -0)
            {
                _current += 1;
            }

            if (_position < _itemCount)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _current = 1;
            _position = 0;
        }
    }
}
