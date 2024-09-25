Stack<char> caracteres = new Stack<char> ();
foreach(char c in "DARCY DA MONTANHA")
{
    caracteres.Push (c);
}
 
string invertido = string.Empty;
while(caracteres.Count > 0)
{
    invertido += caracteres.Pop ();
}

Console.WriteLine (invertido);
