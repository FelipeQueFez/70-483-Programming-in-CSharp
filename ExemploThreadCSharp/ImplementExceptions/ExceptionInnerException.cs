using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploThreadCSharp.ImplementExceptions
{
    public abstract class ExceptionInnerException
    {
        public static void ExemploCreate()
        {
            try
            {
                int a = int.Parse("erro");
            }
            catch (FormatException ex)
            {
                //Caso tenha que lançar uma nova exception a partir de uma já lançada, deve-se sempre informar a 
                //innerException, que nada mais é que a primeira exception acionada.
                throw new Exception("Ocorreu um erro ao converter os valores.",ex);
            }
        }
    }
}
