using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.Delegate
{
    public abstract class DelegateCovariancia
    {
        private delegate TextWriter CovarianceDel();

        /// <summary>
        /// StreamWriter herda de TextWriter
        /// </summary>
        /// <returns></returns>
        private static StreamWriter MethodStream() { return null; }

        /// <summary>
        /// StringWriter herda de TextWriter
        /// </summary>
        /// <returns></returns>
        private static StringWriter MethodString() { return null; }

        /// <summary>
        /// Quando você atribuir um método a um delegado, 
        /// a assinatura do método não tem de coincidir com o delegado exatamente. 
        /// Isso é chamado de covariância e contravariância. 
        /// Covariance torna possível que um método tem um tipo de retorno que é mais 
        /// derivadas do que a definida no delegado. Contravariance permite um método 
        /// que tem tipos de parâmetros que são menos do que os derivados do tipo delegado.
        /// </summary>
        public static void ExemploCreate()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
