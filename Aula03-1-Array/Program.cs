//Array unidimensional
int[] numbers;

numbers = new int[5];

//Atribuicao de valor direta ao indice do vetor
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//Declaracao incializada
string[] names = 
    { "Eu", "Tu", "Ele", "Nós", "Vós", "Eles"};

 //Exemplo vetor com os nomes dos meses
string[] months = new string[12];
for(int i = 1; i <= 12; i++)
{
    DateTime firsDay = 
        new DateTime(DateTime.Now.Year, i, 1);

    string name = firsDay.ToString("MMMM");

    months[i-1] = name;
}

foreach(string m in months)
{
    Console.WriteLine(m);
}