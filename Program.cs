using System;

namespace TakumiUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new StringUtility(@"□□□□□□□□□□
□□□□□□□□□□□□□□□□□□□□■
□□□□□□□□□□□□□
□□□□□□□□□□□□□□□□□■");
            var ret = temp.SplitEx(5, "\r\n");
            Console.Write(ret);
        }
    }
}
