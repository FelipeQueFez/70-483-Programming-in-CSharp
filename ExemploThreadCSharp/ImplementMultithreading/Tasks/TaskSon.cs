using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Tasks
{
    public abstract class TaskSon
    {
        /// <summary>
        /// Exemplo de utilização de task em cascata, criando uma hierarquia de 'pai' e 'filho'.
        /// Onde o 'pai' só em finalizado quando todos os filhos terminam sua execução.
        /// </summary>
        public static void ExemploTaskFilho()
        {
            //Task 'Pai'
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];                

                // Task 'filho'
                new Task(() => results[0] = 0,
                TaskCreationOptions.AttachedToParent).Start();

                // Task 'filho'
                new Task(() => results[1] = 1,
                TaskCreationOptions.AttachedToParent).Start();

                // Task 'filho'
                new Task(() => results[2] = 2,
                TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            // Para cada task filho, escreve na tela o conteúdo da mesma.
            var finalTask = parent.ContinueWith(
            parentTask =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            finalTask.Wait();
        }        
    }
}
