using System;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.LambdaExpression
{
    public abstract class LambdaCreate
    {
        private delegate int Calculate(int x, int y);

        /// <summary>
        /// Exemplo de utilização de expressão lambda para delegação
        /// </summary>
        public static void ExemploCreate()
        {
            //Método anônimo
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7

            //Método anônimo
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
