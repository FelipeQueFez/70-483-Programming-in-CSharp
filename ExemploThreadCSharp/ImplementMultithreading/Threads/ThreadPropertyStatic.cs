using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadPropertyStatic
    {
        /// <summary>
        /// Uma propridade com o atributo 'ThreadStatic', não é compartilhada entre as threads.
        /// </summary>
        [ThreadStatic]
        public static int _field;

        /// <summary>
        /// Exemplo de utilização de NÃO compartilhamento de propriedade de classe entre threads.
        /// </summary>
        public static void ExemploAtributoEstatico()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();
        }                
    }
}
