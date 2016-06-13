using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ManageMultithreading.CancellingTask
{
    public abstract class ContinueWith
    {
        /// <summary>
        /// Exemplo de cancelamento de task com implemtação de continuação.
        /// </summary>
        public static void ExemploCreate()
        {
            //Classe resposável por cancelar uma task em determinado memento quando necessário.
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                //Enquanto a task não for cancelada
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

            }, token).ContinueWith((t) =>
            {
                t.Exception.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled); 
            // Só continua a executar este trecho de código, quando a task for cancelada.
        }
    }
}
