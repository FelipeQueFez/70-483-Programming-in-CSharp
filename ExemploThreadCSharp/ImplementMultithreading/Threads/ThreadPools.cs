using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadPools
    {
        /// <summary>
        /// Exemplo de criação de fila de threads, neste caso é criada 10 threads, onde cada uma executa o método
        /// 'Method05' passando valores diferentes por parâmetro.
        /// </summary>
        public static void ExemploPool()
        {
            for (int i = 0; i < 10; i++)
            {
               ThreadPool.QueueUserWorkItem(Method05, i);
            }
        }

        private static void Method05(object arg)
        {
            Console.WriteLine(string.Concat("Teste... ", arg));
        }
    }
}
