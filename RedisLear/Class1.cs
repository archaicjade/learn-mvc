using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StackExchange.Redis;

namespace RedisLear
{
    //public static ConnectionMultiplexer Manager
    //{
    //    get
    //    {
    //        if (_redis == null)
    //        {
    //            lock (_locker)
    //            {
    //                if (_redis != null) return _redis;

    //                _redis = GetManager();
    //                return _redis;
    //            }
    //        }

    //        return _redis;
    //    }
    //}

    //private static ConnectionMultiplexer GetManager(string connectionString = null)
    //{
    //    if (string.IsNullOrEmpty(connectionString))
    //    {
    //        connectionString = GetDefaultConnectionString();
    //    }

    //    return ConnectionMultiplexer.Connect(connectionString);
    //}
}
