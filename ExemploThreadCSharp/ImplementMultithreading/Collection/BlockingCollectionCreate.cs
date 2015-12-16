using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementMultithreading.Collection
{
    public abstract class BlockingCollectionCreate 
    {
        /// <summary>
        /// Exemplo de utilização do objeto 'BlockingCollection', que é uma lista tipada
        /// compartilhada entre threads.
        /// </summary>
        public static void ExemploCriar()
        {
            ///Uma lista compartilhada entre threads, onde é possivel limitar o limite de itens(opcional),
            ///Adicionar ou remover itens.
            using (BlockingCollection<int> bc = new BlockingCollection<int>())
            {
                //Cria task que adiciona items a lista
                using (Task t1 = Task.Factory.StartNew(() =>
                {
                    bc.Add(1);
                    bc.Add(2);
                    bc.Add(3);
                    bc.CompleteAdding();
                }))
                {
                    //Cria task que percorre cada item da lista.
                    using (Task t2 = Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            // Captura cada elemento da lista
                            while (true)
                            {
                                Console.WriteLine(bc.Take());
                            }
                        }
                        catch (InvalidOperationException)
                        {
                            // Um InvalidOperationException significa que Take ( ) foi chamado em uma coleção concluída
                            Console.WriteLine("That's All!");
                        }
                    }))
                    {

                        Task.WaitAll(t1, t2);
                    }
                }
            }
        }
    }
}
