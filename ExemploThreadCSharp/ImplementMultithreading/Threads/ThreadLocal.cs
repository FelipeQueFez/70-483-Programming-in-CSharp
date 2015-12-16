using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadLocal
    {        
        /// <summary>
        /// Captura informações específicas da thread que invoca esta propriedade.
        /// </summary>
         public static ThreadLocal<int> _field = 
            new ThreadLocal<int>(() => 
            {
                return Thread.CurrentThread.ManagedThreadId;                
            });

        /// <summary>
        /// Exemplo de captura de informações de cada thread em execução.
        /// </summary>
         public static void ExemploLocal()
         {
             new Thread(() =>
                 {
                     for (int x = 0; x < _field.Value; x++)
                     {                         
                         Console.WriteLine("Thread A: {0}", x);
                     }
                 }).Start();

             new Thread(() =>
                 {
                     for (int x = 0; x < _field.Value; x++)
                     {                         
                         Console.WriteLine("Thread B: {0}", x);
                     }
                 }).Start();
         }
    }
}
