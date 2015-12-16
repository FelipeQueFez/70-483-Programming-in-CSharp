using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadStop
    {
        /// <summary>
        /// Exemplo de utilização de espera de ação do usuário para dar um 'stop' em thread em
        /// execução.
        /// </summary>
        public static void ExemploStop()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}
