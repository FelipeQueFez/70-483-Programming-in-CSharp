using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.LambdaExpression
{
    public abstract class LambdaAction
    {
        /// <summary>
        /// Utilização de classe action para trabalhar com delegação
        /// </summary>
        public static void ExemploCreate()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            calc += (x, y) => Console.WriteLine("Divisão: " + (x/y));

            calc(6, 2);
        }
    }
}
