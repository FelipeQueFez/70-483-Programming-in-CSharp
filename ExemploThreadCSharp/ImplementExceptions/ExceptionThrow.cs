using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementExceptions
{
    public abstract class ExceptionThrow
    {
        public static void ExemploCreate(string valor)
        {
            try
            {
                int a = int.Parse(valor);
            }
            catch (FormatException ex)
            {
                //throw ex;
                //throw;
                //throw new class;
            }
        }
    }
}
