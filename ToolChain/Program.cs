using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolChain
{
    class Program
    {
        public static void customFunc(int a, int b)
        {
            int total = a + b;
            Console.Write("Sum is "+ total);
        }
        static void Main(string[] args)
        {
            Console.Write("Hello World");
        }
    }
}
