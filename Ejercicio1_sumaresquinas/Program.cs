using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_sumaresquinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(1, 20);
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int sumaEsquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];


            Console.WriteLine("Suma de las esquinas: " + sumaEsquinas);

            Console.ReadKey();
        }
    }
    
}
