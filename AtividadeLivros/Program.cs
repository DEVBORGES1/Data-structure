using System;
using System.Collections.Generic;
using System.Linq;
using AtividadeLivros;



List<Book> livro = new List<Book>();
livro.Add(new Book(){
    Nome = "A Arte da Guerra",
    Editora = "Estação Liberdade",
    Autor = "Sun Tzu",
    NumeroPaginas = 160,
});

livro.Add(new Book(){
    Nome = "IT, A coisa",
    Editora = "Suma",
    Autor = "Stephen King",
    NumeroPaginas = 1104,
});

livro.Add(new Book(){
    Nome = "48 Leis do Poder",
    Editora = "Rocco",
    Autor = "Robert Greene",
    NumeroPaginas = 554,
});

livro.Add(new Book(){
    Nome = "1984",
    Editora = "Companhia das Letras",
    Autor = "George Orwell",
    NumeroPaginas = 416,
});

livro.Add(new Book(){
    Nome = "Revolução dos Bichos",
    Editora = "Companhia das Letras",
    Autor = "George Orwell",
    NumeroPaginas = 152,
});

Book MaisPaginas = livro.OrderByDescending(l => l.NumeroPaginas).FirstOrDefault()!;

    if (MaisPaginas != null)
    {
    Console.WriteLine("Livro com o maior número de paginas:");
    Console.WriteLine($"Nome: {MaisPaginas.Nome}");
    Console.WriteLine($"Editora: {MaisPaginas.Editora}");
    Console.WriteLine($"Autor: {MaisPaginas.Autor}");
    Console.WriteLine($"Numero de páginas: {MaisPaginas.NumeroPaginas}");

    }   