using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Threads
{
    public abstract class ThreadParameter
    {
        /// <summary>
        /// Exemplo de utilização de thread sem a passagem de parâmetros para um método.
        /// </summary>
        public static void ExemploSemParametro()
        {
            Thread t = new Thread(new ThreadStart(Helper.Method01));
            t.Start();
        }

        /// <summary>
        /// Exemplo de utilização de thread passando valores por parâmetro para um método.
        /// </summary>
        public static void ExemploComParametro()
        {
            //1º Forma de passagem de parâmetro por Thread.
            //Thread t = new Thread(new ParameterizedThreadStart(Method02));

            //2º Forma de passagem de parâmetro por Thread.
            Thread t = new Thread(() => Helper.Method02("Felipe 2"));

            t.Start("Felipe");
        }
    }
}
