using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Digite uma palavra:");
    string palavra = Console.ReadLine()!;

    if (Palindromo(palavra))
    {
        Console.WriteLine($"A palavra '{palavra}' é um palindromo");
    }
    else
    {
        Console.WriteLine($"A palavra '{palavra}' não é um palindromo");
    }
    }
    static bool Palindromo(string palavra)
    {
    Stack<char> caracteres = new Stack<char> ();
    foreach(char c in palavra)
    {   
    caracteres.Push (c);

    }
    foreach(char c in palavra)
     {
         if(c != caracteres.Pop())
        {
        return false;
        }
     }
    return true;
    }
}