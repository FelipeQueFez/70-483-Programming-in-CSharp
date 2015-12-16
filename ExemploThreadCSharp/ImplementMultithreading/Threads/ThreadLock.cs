using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadLock
    {
        static bool done;
        static readonly object locker = new object();

        private static void Method04()
        {
            //Equanto o objeto 'locker' estiver sendo usado por uma thread,
            //o programa não prossegue execução, é criado uma fila de espera até que o
            //objeto esteja disponível.
            lock (locker)
            {
                Thread.Sleep(5000);
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }

        /// <summary>
        /// Exemplo de utilização da palavra reservada 'lock' no contexto de thread.
        /// </summary>
        public static void ExemploLock()
        {
            new Thread(Method04).Start();
            Method04();
        }
    }
}
