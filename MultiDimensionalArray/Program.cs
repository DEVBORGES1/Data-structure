using System;
using System.Numerics;

// Criando um vetor multidimensional com 5 linhas e 2 colunas

int[,] numbers = new int [5,2];

//Criando um vetor tridimensional

int[,,] triNumbers = new int[5,4,3];

//Podemos inicializar os valores do vetor no momento de sua declaração

int [,] iniNumbers = new int[,]
{
    {9,5,-9},
    {19,25,-90},
    {29,35,-91},
    {39,45,-92},
    {49,55,-93},
};

//Para acessar os valores contidos nesse tipo de variavel
int valor = iniNumbers[0,1]; //Neste caso = 15

Console.WriteLine( $"iniNumbers[0,1] == {valor}" );

int maior = iniNumbers[0,0];
int menor = iniNumbers[0,0];

for (int i = 0; i < iniNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < iniNumbers.GetLength(1); j++)
        {
            if (iniNumbers[i, j] > maior)
            {
                maior = iniNumbers[i, j];
            }
            if (iniNumbers[i, j] < menor)
            {
                menor = iniNumbers[i, j];
            }
        }
    }

    Console.WriteLine("Maior número: " + maior);
    Console.WriteLine("Menor número: " + menor);