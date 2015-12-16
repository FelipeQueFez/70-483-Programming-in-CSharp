using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Parallels
{
    public abstract class ParallelCreate
    {
        /// <summary>
        /// Exemplo de utilização de classe 'Parallel' para trabalhar com processamento multiplo.
        /// Você deve usar a classe paralela somente quando seu código não tem que ser executado seqüencialmente.
        /// </summary>
        public static void ExemploParallelCriar()
        {
            var r1 = Parallel.For(0, 10, i =>
            {
                Console.WriteLine(string.Concat("For - ", i));
            });

            var numbers = Enumerable.Range(0, 10);

            var r2 = Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine(string.Concat("For each - ", i));
            });            
        }
    }
}
