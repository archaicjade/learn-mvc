using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public interface ILog
    {
        string SaveLog(string message);
    }

    public class Log : ILog
    {
        public string SaveLog(string message)
        {
            return "log ：" + message;
        }
    }

    public class ProductService
    {
        private ILog _log;
        public ProductService(ILog logger)
        {
            this._log = logger;
        }
    }

    public class TextLog : ILog
    {
        public string SaveLog(string message)
        {
            return "textLog ：" + message;
        }
    }
}
