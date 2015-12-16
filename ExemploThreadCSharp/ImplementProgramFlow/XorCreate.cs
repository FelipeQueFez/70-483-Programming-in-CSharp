using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploThreadCSharp.ImplementProgramFlow
{
    public abstract class XorCreate
    {
        /// <summary>
        /// O Exclusive operador OR (XOR) retorna true somente quando exatamente UM dos operandos é verdadeiro.         
        /// </summary>
        public static void ExemploCreate()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False
        }
    }
}
