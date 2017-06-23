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
            //string conStr = ConfigurationManager.AppSettings["RedisConnect"];

            //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(conStr);

            //IDatabase db = redis.GetDatabase();
            //string mykey = "redisKey";
            //long k = 123123;
            //db.StringSet(mykey, k);
            //Console.WriteLine(db.StringGet(mykey));
            //foreach (var item in Enumerable.Range(0, 10000))
            //{
            //    db.StringIncrementAsync(mykey, 1);

            //}


            //Console.WriteLine(db.StringGet(mykey));

            //Console.ReadKey();

            string ss = " iiioll 咯懂😡😏😣😠😠😄👏👴👏👏🐷🐷🐔🐦🌷🌷🌷🍂🍂🎍🍆🍉🍘🍲🍊🚕🚹🚺🚒🚃";

            string sss = RemoveNoneXmlUnicode(ss);

            Console.ReadKey();
        }

        private static string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16);
            }
            return result;
        }
        /// <summary>
        /// 过滤非XML字符集的字符
        /// <code>baiyu 2015-08-27</code>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveNoneXmlUnicode(string source)
        {
            if (source == null || source.Length == 0) return source;

            char[] charArray = source.ToCharArray();
            List<char> charList = new List<char>(charArray.Length);

            foreach (char character in charArray)
            {
                if (!isEmojiCharacter(character)) continue;
                charList.Add(character);
            }

            if (charList.Count == 0) return string.Empty;
            string content = new String((charList.ToArray()));

            return content;
        }

        /// <summary>
        /// 判断是否为Emoji字符
        /// <code>baiyu 2015-08-27</code>
        /// </summary>
        /// <param name="codePoint"></param>
        /// <returns></returns>
        private static bool isEmojiCharacter(char codePoint)
        {
            //return (codePoint == 0x0) ||
            //        (codePoint == 0x9) ||
            //        (codePoint == 0xA) ||
            //        (codePoint == 0xD) ||
            //        ((codePoint >= 0x20) && (codePoint <= 0xD7FF)) ||
            //        ((codePoint >= 0xE000) && (codePoint <= 0xFFFD)) ||
            //        ((codePoint >= 0x10000) && (codePoint <= 0x10FFFF));

            return (codePoint == 0x0) ||
                    (codePoint == 0x9) ||
                    (codePoint == 0xA) ||
                    (codePoint == 0xD) ||
                    ((codePoint >= 0x20) && (codePoint <= 0xD7FF)) ||
                    ((codePoint >= 0xE000) && (codePoint <= 0xFFFD));
        }
    }
}
