using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.CreateImplementEventsCallbacks.Delegate
{
    public abstract class DelegateContraCovariancia
    {
        static void DoSomething(TextWriter tw) { }

        /// <summary>
        /// StreamWriter herda de TextWriter
        /// </summary>
        /// <param name="tw"></param>
        public delegate void ContravarianceDel(StreamWriter tw);

        /// <summary>
        /// O método DoSomething pode trabalhar com um TextWriter, certamente também pode trabalhar com
        /// um StreamWriter.Por causa de contravariance, você pode chamar o delegado e passar uma instância de
        /// StreamWriter com o método DoSomething.
        /// </summary>
        public static void ExemploCreate()
        {
            ContravarianceDel del = DoSomething;
        }        
    }
}
