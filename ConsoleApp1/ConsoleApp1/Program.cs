using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Helloworld
    {
        public Helloworld()
        {
            Console.WriteLine("Hello,World!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Helloworld hello = new Helloworld();
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }
}
