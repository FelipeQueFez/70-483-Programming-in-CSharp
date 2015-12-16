using ManageProgramFlow.CreateImplementEventsCallbacks.Delegate;
using ManageProgramFlow.CreateImplementEventsCallbacks.LambdaExpression;
using ManageProgramFlow.ImplementExceptions;
using System;

namespace ExemploThreadCSharp
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                ExceptionThrow.ExemploCreate("felipe");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                
            }            
        }
    }
}
