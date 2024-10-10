using InsertionSort;


int[] inteiros = {1,23,4,5,6,8,455,3,44,};

InsertionSort.InsertionSort.Print(inteiros);
InsertionSort.InsertionSort.Sort<int>(inteiros);
InsertionSort.InsertionSort.Print(inteiros);

Console.WriteLine("\nTeste char");
char[] chars = {'a','b','c','d','e','f'};
InsertionSort.InsertionSort.Print(chars);
InsertionSort.InsertionSort.Sort(chars);
InsertionSort.InsertionSort.Print(chars);
