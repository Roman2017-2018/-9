using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Text_Editor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content1 { get; set; }
        void GetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form,IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            OpenFile.Click += OpenFile_Click;
            numFont.ValueChanged += NumFont_ValueChanged;
            butSaveFile.Click += ButSaveFile_Click;
            SelectFile.Click += SelectFile_Click;
            Content.TextChanged += Content_TextChanged;
        }

        private void NumFont_ValueChanged(object sender, EventArgs e)
        {
            Content.Font = new Font("Calibri",(float)numFont.Value);
        }
        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Текстовые  файлы|*.txt|Вме файлы|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = d.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }

        }

        #region Проброс событий
        private void Content_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick (this, EventArgs.Empty);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this,EventArgs.Empty);
        }
        #endregion
        #region Реализация интерфеса IMainForm
        public string FilePath { get { return filePath.Text; } }
        public string Content1 { get { return Content.Text; }set { Content.Text = value; } }
        public void GetSymbolCount(int count)
        {
            SymbolCount.Text = count.ToString();
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion
    }
}
