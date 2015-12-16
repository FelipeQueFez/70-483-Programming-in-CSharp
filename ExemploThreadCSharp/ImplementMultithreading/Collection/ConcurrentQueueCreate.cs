using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Collection
{
    public abstract class ConcurrentQueueCreate
    {
        /// <summary>
        /// Exemplo de utilização do objeto 'ConcurrentQueue', que é uma fila compartilhada entre threads.
        /// </summary>
        public static void ExemploCriar()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            queue.Enqueue(21);
            int result;

            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
        }
    }
}
