// Exemplo de uma agenda telefônica 

using System;
using System.Collections;

Hashtable phonebook = new Hashtable()
{
    { "LUIS", "49-99990-2488" },
    { "MAURICIO GONZATTO", "49-99975-8575" },
    { "Gabriel Bianchi", "49-99105-8904" }
};

// É possível adicionar elementos de diversas formas 
phonebook["FABIANO"] = "49-99176-8255";

// Ou pelo método Add()
phonebook.Add("Marcos Henrique", "49-99202-6169");

// Entretanto, a tabela hash verifica se há 
// duplicidade de chave e pode lançar uma 
// exceção 

try
{
    phonebook.Add("MAURICIO GONZATTO", "49-99975-8575");
}
catch (Exception ex)
{
    Console.WriteLine("Deu pau aqui, viado, repetiu o valor demais");
    Console.WriteLine(ex.Message);
    
}

Console.WriteLine("Agenda telefônica.");
if (phonebook.Count == 0)
{
    Console.WriteLine("A agenda está vazia.");
}
else
{
    foreach (DictionaryEntry entry in phonebook)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}
