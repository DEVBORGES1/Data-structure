// Escreva um algoritmo que armazene em dois vetores separados os primeiros 100 números pares e ímpares.
// No final, imprima a sequência armazenada em cada um deles

using System;

class Program
{
    static void Main()
    {
        int[] pares = new int[100];
        int[] impares = new int[100];
        int parIndex = 0, imparIndex = 0;

        for (int i = 1; parIndex < 100 || imparIndex < 100; i++)
        {
            if (i % 2 == 0 && parIndex < 100)
            {
                pares[parIndex] = i;
                parIndex++;
            }
            else if (i % 2 != 0 && imparIndex < 100)
            {
                impares[imparIndex] = i;
                imparIndex++;
            }
        }

        Console.WriteLine("Números Pares:");
        foreach (int par in pares)
        {
            Console.Write(par + " ");
        }

        Console.WriteLine("\n\nNúmeros Ímpares:");
        foreach (int impar in impares)
        {
            Console.Write(impar + " ");
        }
    }
}
    







