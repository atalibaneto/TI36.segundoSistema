using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operadores Lógicos
            && - retorna true se ambas as instruções forem verdadeiras
            || - retorna true se uma das instruções for verdadeira
            !  - reverte o resultado, retorna falso se o resultado for verdadeiro
             */

            int x = 5;
            Console.WriteLine(x > 3 && x < 10); //ambos são verdadeiros

            int y = 5;
            Console.WriteLine(y > 6 || y <10); //1 tem q ser verdadeiro

            int z = 5;
            Console.WriteLine(!(z > 3 && z < 10)); //inverte a resposta

        }
    }
}
