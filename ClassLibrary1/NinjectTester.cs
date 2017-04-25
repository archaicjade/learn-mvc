using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ITester
    {
        void Test();
    }
    public class NinjectTester : ITester
    {
        public string Message { get; set; }


        private ILogger _logger;

        public NinjectTester(ILogger logger)
        {
            this._logger = logger;
        }
        public void Test()
        {
            _logger.Write("Hello Ninject !");
            _logger.Write(Message);
        }
    }
}
