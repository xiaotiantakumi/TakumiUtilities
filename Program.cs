using System;

namespace TakumiUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new StringUtility("aiueo");
            var ret = temp.StartWith("aiu");
            Console.Write(ret);
        }
    }
}
