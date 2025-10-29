using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrupoM17C_Pert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            
            for (int v = 0; v < numeros.Length; v++)
            {
                Console.Write($"Digite o {v + 1}º número > ");
                numeros[v] = int.Parse(Console.ReadLine());
            }

            
            int maximo = numeros[0];
            int indice = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    indice = i;
                }
            }

            
            Console.WriteLine("\nNúmeros digitados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            
            Console.WriteLine($"\nMaior número: {maximo}, índice: {indice + 1}");

            Console.ReadKey();
        }
    }
}