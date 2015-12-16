using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ManageMultithreading.Volatile
{
    public abstract class VolatileCreate
    {
        /// <summary>
        /// A palavra-chave volatile indica que um campo pode ser modificado por vários 
        /// segmentos que estão em execução ao mesmo tempo.Os campos que são declarados 
        /// volatile não são sujeitos a otimizações do compilador que assumem o acesso por uma única thread. 
        /// Isso garante que o valor mais atualizado está presente no campo em todos os momentos.
        /// O volatile modificador geralmente é usado para um campo que é acessado por vários threads
        /// sem usar o lock instrução para serializar o acesso.
        /// Fonte: https://msdn.microsoft.com/pt-br/library/x13ttww7.aspx
        /// </summary>
        private static volatile int _flag = 0;
        private static int _value = 0;

        public static void ExemploCreate()
        {
            Task.Run(() => Thread1());
            Task.Run(() => Thread2());

            Console.ReadLine();
        }

        private static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        private static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }   
    }
}
