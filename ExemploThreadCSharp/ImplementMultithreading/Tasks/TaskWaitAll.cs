using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Tasks
{
    public abstract class TaskWaitAll
    {
        /// <summary>
        /// Exemplo de utilização de método 'WaitAll'.
        /// </summary>
        public static void ExemploWaitAll()
        {
            //Lista de tasks.
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            //Espera todas as tasks finalizarem
            Task.WaitAll(tasks);
        }
    }
}
