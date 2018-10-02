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

namespace Множества
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Progression progression = new Progression(109);
            foreach (int i in progression)
            {
                richTextBox1.Text += i.ToString();
            }
        }




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
            return new ProgressionIterator(_itemCount);
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
