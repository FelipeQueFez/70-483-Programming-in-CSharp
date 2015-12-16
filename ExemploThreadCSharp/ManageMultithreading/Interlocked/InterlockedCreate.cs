using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ManageMultithreading.Interlocked
{
    public abstract class InterlockedCreate
    {
        public static void ExemploCreate()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    System.Threading.Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
               System.Threading.Interlocked.Decrement(ref n);

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
