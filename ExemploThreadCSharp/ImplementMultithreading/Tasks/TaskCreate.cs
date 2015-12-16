using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Tasks
{
    public abstract class TaskCreate
    {
        /// <summary>
        /// Exemplo de criação simpes de task
        /// </summary>
        public static void ExemploCriar()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine("*");
                }
            });

            //Equivalente ao método 'Join' da thread. Onde tudo aquilo que vier após essa linha
            //Só será executado quando a task for finalizada.
            t.Wait();
        }

        /// <summary>
        /// Exemplo de criação de task com continuidade ao final da execução.
        /// </summary>
        public static void ExemploCriarContinue()
        {
            Task<int> t = Task.Run(() =>
            {
                return 1;

            }).ContinueWith((i) => { // Captura o retorno do que ocorreu no método "Run" e continua execução.
                return i.Result +1;
            });

            Console.WriteLine(t.Result);
        }

        /// <summary>
        /// Exemplo de criação de task com continuidade somente para quando ocorrer exceções.
        /// </summary>
        public static void ExemploCriarContinue02()
        {
            Task<int> t = Task.Run(() =>
            {                
                return Convert.ToInt32("abc");
                //return 42;                    
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine(string.Concat("Faulted - ", i.Exception.InnerException.Message));
            }, TaskContinuationOptions.OnlyOnFaulted);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);            
        }        
    }
}
