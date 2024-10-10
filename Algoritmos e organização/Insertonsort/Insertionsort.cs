using System;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static void Print<T>(T[] array)
        {
            Console.Write('[');
            foreach (T i in array){
                Console.Write($"{i} ");
            }
            Console.Write(']');
        }
    }
}
