using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using StackExchange.Redis;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RedisLear
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = ConfigurationManager.AppSettings["RedisConnect"];

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(conStr);

            IDatabase db = redis.GetDatabase();
            string mykey = "redisKey";
            long k = 123123;
            db.StringSet(mykey, k);
            Console.WriteLine(db.StringGet(mykey));
            foreach (var item in Enumerable.Range(0, 1000000))
            {
                db.StringIncrementAsync(mykey, 1);

            }


            Console.WriteLine(db.StringGet(mykey));

            Console.ReadKey();

        }
    }
}
