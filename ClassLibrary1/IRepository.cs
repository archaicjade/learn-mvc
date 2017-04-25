using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IRepository
    {
        void Get(string commmandText);
    }

    public class SqlRepository : IRepository
    {

        public void Get(string commmandText)
        {
            Console.WriteLine("sql数据源：" + commmandText);
        }
    }

    public class RedisRepository : IRepository
    {
        public void Get(string commmandText)
        {
            Console.WriteLine("redis数据源：" + commmandText);
        }
    }

    public class DBBase
    {
        private IRepository _res;

        public DBBase(IRepository repos)
        {
            this._res = repos;
        }

        private string _name;
        public DBBase(string name, IRepository repos)
        {
            this._name = name;
            this._res = repos;
        }

        public void Search(string commandText)
        {
            Console.WriteLine(this._name);
            _res.Get(commandText);
        }
    }
}
