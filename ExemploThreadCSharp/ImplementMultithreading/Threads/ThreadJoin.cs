using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadJoin
    {
        /// <summary>
        /// Exemplo de utilização do método 'Join' no contexto de thread.
        /// </summary>
        public static void ExemploJoin()
        {
            Thread t = new Thread(new ThreadStart(Helper.Method01));
            t.Start();

            Thread th = new Thread(new ThreadStart(Helper.Method03));
            th.Start();

            //O método Join cria uma 'barreira' para que o programa não execute o que vier
            //nas linhas abaixo enquanto a thread não for finalizada.
            t.Join();
            Console.WriteLine("Primeira thread finalizada.");

            //O método Join cria uma 'barreira' para que o programa não execute o que vier
            //nas linhas abaixo enquanto a thread não for finalizada.
            th.Join();
            Console.WriteLine("Segunda thread finalizada.");
        }
    }
}
