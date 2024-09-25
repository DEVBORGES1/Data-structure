//JagerArray é o array do Ceará
// JaggedArray é também conhecido como um vetor de vetores

int [][] numbers = new int[4][];
//Neste caso [][] indica que é um vetor de vetor, neste exemplo um vetor contendo 4 posições contendo vetores de tamanhho

numbers[0] = new int[] {1,2,3};
numbers[1] = new int[] {4,3,2,1,0};
numbers[2] = new int[] {1,2,0};
numbers[3] = new int[] {57};
numbers[4] = null!;

//Para obter valor de jaggedArray
int valor = numbers[0][2];
Console.WriteLine(valor);

//Para atribuir um valor em um JaggedArray
numbers[1][2] = 0;
Console.WriteLine (numbers[1][2]);

