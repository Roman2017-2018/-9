using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextEditor_BL
{  public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);

    }
   public class FileManager:IFileManager
    {
        public bool IsExist (string filePath)
        {
            return File.Exists(filePath);
        }
        private readonly Encoding _encoding = Encoding.GetEncoding(1251);
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _encoding);
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath,encoding);
            return content;
        }
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _encoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath,content,encoding);
        }
        public int GetSymbolCount(string content)
        {
            return content.Length;
        }
    }
}
