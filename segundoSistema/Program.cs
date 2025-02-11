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

            //Classe Math

            Console.WriteLine(Math.Max(40, 200)); //retorna o maior valor
            Console.WriteLine(Math.Min(40, 200)); //retorna o menor valor
            Console.WriteLine(Math.Sqrt(144)); // retorna a raíz quadrada
            Console.WriteLine(Math.Round(4.6)); //arredonda o valor

            //Atividade - Classe Math
            //Maior e menor entre 3 números

            Console.WriteLine("\n======= Atividade 1 ========");
            Console.WriteLine("Digite o 1º número");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3º número");
            int terceiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O maior número digitado foi: {Math.Max(terceiroNumero, Math.Max(primeiroNumero, segundoNumero))}");
            Console.WriteLine($"O menor número digitado foi: {Math.Min(terceiroNumero, Math.Min(primeiroNumero, segundoNumero))}");
        }
    }
}
