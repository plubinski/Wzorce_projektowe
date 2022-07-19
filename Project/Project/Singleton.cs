using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    public sealed class Singleton
    {
        private string _path = "logs.txt";
        private Singleton()
        {
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void SaveLogToFile(string log)
        {
            File.AppendAllText(_path, log+"\n"); 
        }

        public string ReadLogFile()
        {
            return File.ReadAllText(_path);
        }
    }
}
