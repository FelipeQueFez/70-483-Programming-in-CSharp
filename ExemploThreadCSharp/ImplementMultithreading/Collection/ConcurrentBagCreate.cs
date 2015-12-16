using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Collection
{
    public abstract class ConcurrentBagCreate
    {        
        /// <summary>
        /// Exemplo de utilização do objeto 'ConcurrentBag', que é uma lista tipada 
        /// compartilhada entre threads.
        /// </summary>
        public static void ExemploCriar()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });            

            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();
        }

        /// <summary>
        /// Exemplo de utilização do objeto 'ConcurrentBag', que é uma lista tipada 
        /// compartilhada entre threads.
        /// </summary>
        public static void ExemploCriar02()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}
