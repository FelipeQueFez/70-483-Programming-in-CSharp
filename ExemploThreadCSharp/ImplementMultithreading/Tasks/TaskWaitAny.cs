using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Tasks
{
    public abstract class TaskWaitAny
    {
        /// <summary>
        /// Exemplo de utilização de método 'WaitAny'.
        /// </summary>
        public static void ExemploWaitAny()
        {
            //Lista de tasks.
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0)
            {
                // Espera qualquer Task terminar e captura a mesma.
                int i = Task.WaitAny(tasks);

                // Captura o valor retornado da thread.
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();

                //Remove a task finalizada do array
                temp.RemoveAt(i);
                
                tasks = temp.ToArray();
            }
        }
    }
}
