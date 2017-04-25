using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILogger
    {
        void Write(string message);
    }


    public class FileLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(String.Format("文件记录日志:{0}", message));
        }
    }
}
