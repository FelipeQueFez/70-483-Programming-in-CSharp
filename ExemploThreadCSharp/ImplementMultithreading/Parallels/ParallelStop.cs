using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Parallels
{
    public abstract class ParallelStop
    {
        /// <summary>
        /// Exemplo de utilização da classe 'ParallelLoopResult'
        /// </summary>
        public static void ExemploParallelParar()
        {
            //Captura o retorno
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                //Quando o indice do loop for igual a 500, sai do loop.
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Stop();                    
                }
                
                return;
            });
        }
    }
}
