using System.Collections;

//Utilizando a lista simples vamos declarar um ArrayList
ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Fabiano");

//É possivel adicioar um conjunto de valores de uma so vez
arrList.AddRange(new int[] { 1, 2, 3});

//O metodo Add insere o valor ao final do vetor
arrList.Insert(0, 15);

//Já o metodo insert me permite incluir o valor desejado na posição especificada no primeiro parametro

//Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.Write($" | {obj}");
}

//Obtendo o tamanho total da lista
//Quantos elemento tem
int tamanho = arrList.Count;

//Obter a capacidade
//Quantos podem ser armazenados
int capacidade = arrList.Capacity;

//Percorrendo no modo Classico
for(int i = 0; i < arrList.Count; i++)
{
    Console.WriteLine ($" | {arrList[i]}");
}

//Recursos importantes da lista
//Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("Fabiano");
if(contemNome)
    Console.WriteLine ("Nome Fabiano não encontrado");

//Para saber o indice que contem o valor buscado
// Nests caso se o valor existir na lista ele retorna o indice (numero inteiro)
//Caso o valor não exista na lista, retorna -1
int indiceDoValor = arrList.IndexOf("Fabiano");
if (indiceDoValor >= 0)
    Console.WriteLine ($"Fabiano está em [{indiceDoValor}]");
else
    Console.WriteLine ("É, realmente não tem.");

//É possivel também remover itens da lista
arrList.Remove("Fabiano"); //Remove pelo valor
arrList.RemoveAt(4);
arrList.RemoveRange(0,2); //O primeiro parametro é o indice e o segundo é quantas casa após o indice

