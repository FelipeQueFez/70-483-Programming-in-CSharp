using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementProgramFlow
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public abstract class Foreach
    {
        private static List<Person> people;

        private static void Populate()
        {
            people = new List<Person>
                        {
                        new Person() { FirstName = "John", LastName = "Doe"},
                        new Person() { FirstName = "Jane", LastName = "Doe"},
                        };
        }

        public static void ExemploCreate()
        {
            Populate();
            List<Person>.Enumerator e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;                                        
                }
                //Uma vez percorrido em todos os itens da lista, não é possivel percorrer novamente.        
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }

        public static void ExemploCreateDois()
        {
            Populate();

            foreach (Person p in people)
            {
                p.LastName = "Changed"; // Isso é permitido
                                        // p = new Person(); // Isto dá um erro de compilação                
            }
        }

        /// <summary>
        /// Exemplo de utilização de yield, Enumerable
        /// </summary>
        public static void ExemploCreateTres()
        {
            // Lets see how yield return works
            foreach (int i in YieldReturn())
            {
                Console.WriteLine(i);
            }
        }

        private static IEnumerable<int> YieldReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
