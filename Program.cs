using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //objekt
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");            //visar hela listan            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
