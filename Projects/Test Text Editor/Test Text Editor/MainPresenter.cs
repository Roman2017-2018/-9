using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextEditor_BL;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Test_Text_Editor
{
    class MainPresenter
    {
        private readonly IMessageServies _messagee;
        private readonly IFileManager _manager;
        private readonly IMainForm _view;
        public string _CurrentFilePath;
        public MainPresenter(IMainForm view, IFileManager manage, IMessageServies message)
        {
            _messagee = message;
            _manager = manage;
            _view = view;
            _view.GetSymbolCount(0);
            _view.FileOpenClick += Frm_FileOpenClick;
            _view.ContentChanged += Frm_ContentChanged;
            _view.FileSaveClick += Frm_FileSaveClick;
        }

        public void Frm_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content1 = _view.Content1;
                _manager.SaveContent(_view.Content1,_CurrentFilePath);
                _messagee.ShowMessage("Фаил усешно сохранен !");
            }
            catch (Exception e2)
            {
                
                _messagee.ShowError(e2.Message);
            }
        }

        private void Frm_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                bool isExist = _manager.IsExist(filePath);
                if (!isExist)
                {
                    _messagee.ShowExclamation("Выбранный путь не существует.");
                    return;
                }
                _CurrentFilePath = filePath;
                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);

                _view.Content1 = content;
                _view.GetSymbolCount(count);
            }
            catch (Exception e2)
            {
                _messagee.ShowError(e2.Message);
            }
        }

        private void Frm_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content1;
            int count = _manager.GetSymbolCount(content);
            _view.GetSymbolCount(count);
        }
    }

}



