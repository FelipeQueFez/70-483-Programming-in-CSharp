using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.LambdaExpression
{
    public abstract class LambdaMultiple
    {
        //Criado um delegate que deve retornar um inteiro e ser passado por parâmetro mais dois inteiros
        private delegate int Calculate(int x, int y);

        public static void ExemploCreate()
        {
            //Método anônimo
            Calculate calc =
            (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };

            //Método anônimo
            calc += (x, y) => 
            {
                Console.WriteLine("Haaa heey heeey");
                return 0;
            };

            int result = calc(3, 4);
            // Displays
            // Adding numbers
        }
    }
}
