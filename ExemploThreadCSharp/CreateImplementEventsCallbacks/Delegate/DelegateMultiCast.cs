using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.Delegate
{
    public abstract class DelegateMultiCast
    {
        public delegate void Del();

        /// <summary>
        /// Exemplo de utilização de encadeamento de delegações
        /// </summary>
        public static void ExemploCreate()
        {
            //Adiciona delegação
            Del d = MethodOne;
            d += MethodTwo;
            d += MethodTree;

            if (true)
            {
                //Remove delegação
                d -= MethodOne;
            }

            //Executa o delegate.
            d();
        }

        public static void ExemploLength()
        {
            //Adiciona delegação
            Del d = MethodOne;
            d += MethodTwo;
            d += MethodTree;

            //Captura a quantidade de delegações adicionadas.            
            int invocationCount = d.GetInvocationList().GetLength(0);

            Console.WriteLine(string.Concat("Quantidade de chamadas: ", invocationCount));
        }

        private static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        private static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        private static void MethodTree()
        {
            Console.WriteLine("MethodTree");
        }
    }
}
