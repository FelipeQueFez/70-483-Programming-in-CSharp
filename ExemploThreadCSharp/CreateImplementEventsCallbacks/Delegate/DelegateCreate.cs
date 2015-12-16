using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.Delegate
{
    public abstract class DelegateCreate
    {
        /// <summary>
        /// Criação de delegate para uso posterior.O delegate defini uma assinatura, onde obrigatóriamente,
        /// quando atribuir um método ao delegate, ele deve respeitar esta assinatura. Neste caso, int x, int y
        /// </summary>
        /// <param name="x">Valor inteiro</param>
        /// <param name="y">Valor inteiro</param>
        /// <returns></returns>
        public delegate int Calculate(int x, int y);

        /// <summary>
        /// Faz operação de soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Add(int x, int y) { return x + y; }

        /// <summary>
        /// faz operaçã ode multiplicação
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiply(int x, int y) { return x * y; }

        /// <summary>
        /// Simulação de erro para transparecer entendimento.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int ExemploError(int x) { return x; }

        public static void ExemploCreate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12

            //Isso dá erro de compilação, pois a assinatura do método 'ExemploError' é diferente do que o deleagate espera.
            //calc = ExemploError;
            //Console.WriteLine();
        }
    }
}
