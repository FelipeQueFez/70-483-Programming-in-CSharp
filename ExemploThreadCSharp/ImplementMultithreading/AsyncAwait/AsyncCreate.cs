using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManageProgramFlow.ImplementMultithreading.AsyncAwait
{
    public abstract class AsyncCreate
    {
        /// IMPORTANTE: Ao debugar um método 'async' o compilador nos ajuda, pois quando nos deparamos com
        /// com uma palavra reservada 'await', ó comportamento do debug é de forma sincrona, facilitando 
        /// a vida do desenvolvedor.

        /// <summary>
        /// Exemplo de utilização de programação paralela com 'async' e 'await'
        /// </summary>
        public static void ExemploAsyncAwait()
        {
            DownloadContent();
            FazAlgumaCoisa();
            Soma(10, 10);
            Multiplica(10, 10);
        }
        
        /// <summary>
        /// Um método assíncrono serve para que a aplicação não pare enquanto um determinado processo é
        /// executado. Neste caso, uma pause de 10 segundos.
        /// </summary>
        private static async void FazAlgumaCoisa()
        {
            //A palavra reservada 'await' só pode ser usada quando o método estiver com a nomenclatura 'async'
            //Este comando 'espera' 10 segundos para prosseguir imprimindo na tela o texto
            // 'FazAlgumaCoisa'            
            await Task.Delay(10000);
            Console.WriteLine("FazAlgumaCoisa");
        }

        private static void Soma(int num1, int num2)
        {
            Console.WriteLine("O resultado da soma é : {0} ", num1 + num2);
        }

        private static void Multiplica(int num1, int num2)
        {
            Console.WriteLine("O resultado da multiplicacao é : {0} ", num1 * num2);
        }

        /// Um método assíncrono serve para que a aplicação não pare enquanto um determinado processo é
        /// executado. Neste caso, um download de script de uma página.
        private static async void DownloadContent()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //A palavra reservada 'await' só pode ser usada quando o método estiver com a nomenclatura 'async'
                    //Este comando 'espera' a resposta da requisição.
                    string result = await client.GetStringAsync("http://www.microsoft.com");
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }
    }
}
