using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Collection
{
    public abstract class ConcurrentDictionaryCreate
    {
        /// <summary>
        /// Exemplo de utilização do objeto 'ConcurrentDictionary', que é um dicionário (chave e valor)
        /// compartilhado entre threads.
        /// </summary>
        public static void ExemploCriar()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}
