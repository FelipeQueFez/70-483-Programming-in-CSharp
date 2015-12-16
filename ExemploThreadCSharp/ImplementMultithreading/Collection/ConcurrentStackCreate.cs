using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Collection
{
    public abstract class ConcurrentStackCreate
    {
        /// <summary>
        /// Exemplo de utilização do objeto 'ConcurrentStack', é uma pilha tipada compartilhada entre threads.
        /// </summary>
        public static void ExemploCriar()
        {
            //Push = adiciona
            //Pop = Seleciona
 
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
                Console.WriteLine(i);
        }
    }
}
