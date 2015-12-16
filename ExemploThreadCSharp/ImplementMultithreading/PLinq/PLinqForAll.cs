using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.PLinq
{
    public abstract class PLinqForAll
    {
        /// <summary>
        /// Exemplo de utilização de Método 'AsParallel', 'AsOrdered' e 'ForAll'
        /// </summary>
        public static void ExemploForAll()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered() // Orderna os elementos
            .Where(i => i % 2 == 0);

            //Percorre cada item da lista.
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}
