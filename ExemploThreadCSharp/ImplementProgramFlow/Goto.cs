using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ImplementProgramFlow
{
    public abstract class Goto
    {
        public static void ExemploCreate()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        //Após a execução do primeiro case, faz a transferencia para a execução do case 2
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }
        }

        /// <summary>
        /// Você não pode fazer um salto para um rótulo que não está no escopo. 
        /// Isto significa que você não pode transferir
        //  controle para outro bloco de código que está fora do seu bloco atual.O compilador também faz
        //  Certifique-se de que quaisquer blocos finally que intervêm são executados.
        /// </summary>
        public static void ExemploCreateDois()
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

            customLabel: Console.WriteLine(x);
            // Displays 3
        }                    
    }
}
