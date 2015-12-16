using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Tasks
{
    public abstract class TaskFac
    {
        /// <summary>
        /// Exemplo de utilização de task em cascata, criando uma hierarquia de 'pai' e 'filho'.
        /// Onde o 'pai' só em finalizado quando todos os filhos terminam sua execução. Porém, utilizando
        /// a classe TaskFactory
        /// </summary>
        public static void ExemploFactory()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[4];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);                
                tf.StartNew(() => teste(10));
               
                return results;
            });

            parent.Wait();

            //Captura o retorno da task e imprimi na tela.
            foreach (var item in parent.Result)
            {
                Console.WriteLine(item);
            }
        }

        private static int teste(int a)
        {            
            return a;
        }
    }
}
