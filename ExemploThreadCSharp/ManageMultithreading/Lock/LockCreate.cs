using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ManageMultithreading.Lock
{
    public abstract class LockCreate
    {
        /// <summary>
        /// Exemplo de utilização mal sucedida da palavra chave 'Lock'
        /// </summary>
        private static void ExemploProblema()
        {
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            //Ao inverter a ordem o commando lock, havérá um impasse, onde uma threa irá esperar a outra para prosseguir,
            //porém, ao inverter dessa forma, nenhum dos processos irá prosseguir nunca, caindo em uma espécie de loop infinito.
            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            up.Wait();
        }
    }
}
