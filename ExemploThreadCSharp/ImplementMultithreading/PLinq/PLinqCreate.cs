using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.PLinq
{
    public abstract class PLinqCreate
    {
        ///LINQ paralelo (PLINQ) é uma implementação paralela padrão de LINQ. 
        ///Uma consulta de PLINQ lembra de várias maneiras uma consulta não paralela do LINQ com os objetos. 
        ///As consultas de PLINQ, assim como consultas de LINQ sequenciais,
        ///operam em qualquer fonte de dados de IEnumerable ou de IEnumerable<T> na memória, 
        ///e tem a execução adiada, o que significa que eles não começam a executar até que a 
        ///consulta seja enumerada. A principal diferença é que PLINQ tentar usar completamente
        ///todos os processadores no sistema. Ele faz isso particionando a fonte de dados em segmentos,
        ///e então executando a consulta em cada segmento em segmentos separados de trabalho
        ///paralelamente em vários processadores. Em muitos casos, a execução em paralelo significa 
        ///que a consulta é executada de forma significativamente mais rápida.        
        ///FONTE: https://msdn.microsoft.com/pt-br/library/dd997425(v=vs.110).aspx

        ///OBS: Tenha cuidado quando você estiver usando PLINQ . 
        ///Quando vs tiver coisas simples para fazer, é melhor usar LINQ que PLINQ.
        ///Exemplo: http://www.codeproject.com/Tips/374420/When-to-use-PLINQ-vs-LINQ

        public static void ExemploCriar()
        {
            int[] parallelResult = null;
            int contador = 0;
            
            Task<int[]> t = Task.Run(() => {

                //Faz processamento dividindo em todos os núcleos de processdadores que o hardware dispõe
                //Utilizando PLINQ
                parallelResult = AsParallel(parallelResult);
                
                //Utilizando LINQ
                //parallelResult = AsEnumerable(parallelResult);

                return parallelResult;

            });

            while (parallelResult == null)
            {
                Console.WriteLine(contador);
                contador++;
            }

            t.ContinueWith(item => {
                foreach (var i in item.Result.Take(5))
                    Console.WriteLine(i);
            });
        }
        
        private static int[] AsParallel(int[] parallelResult)
        {
            var numbers = Enumerable.Range(0, 100000000);
            parallelResult = numbers.AsParallel()
            .Where(i => i % 2 == 0)
            .ToArray();
            return parallelResult;
        }

        private static int[] AsEnumerable(int[] parallelResult)
        {
            var numbers = Enumerable.Range(0, 100000000);
            parallelResult = numbers.AsEnumerable()
            .Where(i => i % 2 == 0)
            .ToArray();
            return parallelResult;
        }
    }
}
