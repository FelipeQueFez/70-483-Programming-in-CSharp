using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadCreate
    {
        /// <summary>
        /// Exemplo de criação de thread simples, com chamada para método.
        /// </summary>
        public static void ExemploCriar()
        {
            Thread t = new Thread(new ThreadStart(Method06));
            t.Start();
        }

        private static void Method06()
        {
            Console.WriteLine("Hello World");
        }
    }
}
