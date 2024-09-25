// Diferente da TabelaHash, o Dictionary nos permite 
// especificar o tipo de dado que será utilizado nos pares
// key -> value
// Isso nos fornece uma estrutura fortemente tipada 

Dictionary<string, string> dictionary = 
    new Dictionary<string, string>()
{
    { "Chave 1", "Valor 1" },
    { "Chave 2", "Valor 2" },
};

// OBTER O VALOR DO DICTIONARY
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch (KeyNotFoundException ex) // Captura a exceção específica
{
    Console.WriteLine("Erro não tem essa porra da chave 3.");
    Console.WriteLine(ex.Message);
}

if (dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

if (dictionary.TryGetValue("Chave 4", out string? valor))
{
    Console.WriteLine($"Chave 4: {valor}");
}
else
{
    Console.WriteLine("Chave 4 não encontrada nesse caralho seu porra para de ser burro leproso.");
}

dictionary["Chave 0"] = "Valor 0";

foreach (KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}
