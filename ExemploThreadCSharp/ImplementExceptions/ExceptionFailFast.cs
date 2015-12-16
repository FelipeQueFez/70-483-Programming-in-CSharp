using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementExceptions
{
    public abstract class ExceptionFailFast
    {
        /// Esse método Finaliza um processo sem executar qualquer ativo try/finally finalizadores ou blocos.
        
        /// O FailFast método grava o message cadeia de caracteres para o log de eventos do aplicativo do Windows, 
        /// cria um despejo do seu aplicativo e, em seguida, encerra o processo atual.O message cadeia de caracteres
        /// também está incluída no relatório de erros para a Microsoft.
       
        /// Use o FailFast método em vez do Exit método para encerrar o aplicativo se o estado do seu aplicativo 
        /// está danificado além do reparo e a execução de seu aplicativo try/finally finalizadores e blocos 
        /// irá corromper os recursos do programa.

        public static void ExemploCreate()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }            
        }
    }
}
