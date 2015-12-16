using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementProgramFlow
{
    public abstract class NullCoalescing
    {
        public static void ExemploCreate()
        {
            //Variável int que aceita null
            int? x = null;

            //Caso x seja null, então atribui -1
            int y = x ?? -1;

            //int? x = null;
            //int? z = null;
            //int y = x ??
            //z ??
            //-1;
        }
    }
}
