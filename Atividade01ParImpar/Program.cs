using System;

class Program
{
    static void Main()
    {
        int[] pares = new int[100];
        int[] impares = new int[100];
        int parCont = 0;
        int imparCont = 0;

        for (int i = 0; i < 200; i++)
        {
            if (i % 2 == 0)
            {
                pares[parCont] = i;
                parCont++;
            }
            else
            {
                impares[imparCont] = i;
                imparCont++;
            }
        }

        Console.WriteLine("Numeros pares:");
        foreach (int par in pares)
        {
            Console.Write(par + " ");
        }

        Console.WriteLine("\nNumeros impares:");
        foreach (int impar in impares)
        {
            Console.Write(impar + " ");
        }
    }
}
