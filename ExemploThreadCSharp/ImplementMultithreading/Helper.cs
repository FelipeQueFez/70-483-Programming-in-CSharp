using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading
{
    public abstract class Helper
    {
        public static void Method01()
        {
            Console.WriteLine("Teste... 1");
        }
             
        public static void Method02(object arg)
        {
            Console.WriteLine(string.Concat("Teste... 2", arg));
        }

        public static void Method03()
        {
            Console.WriteLine("Teste... 3");
        }
    }
}
