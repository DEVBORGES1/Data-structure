using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


public class CircularLinkedList<T> : LinkedList<T>
{
    public new IEnumerator GetEnumerator()
    {
    return new CircularLinkedListEnumerator<T>(this);
    }
}

public class CircularLinkedListEnumerator<T> : IEnumerator<T>
{
    private LinkedListNode<T> _current;
    public T Current => _current.Value;
    object IEnumerator.Current => Current;

    public CircularLinkedListEnumerator (LinkedList<T> list)
    {
        _current = list.First;
    }

    public bool MoveNext()
    {
        if (_current == null)
        {
            return false;
        }

        _current = _current.Next ?? _current.List.First;
        return true;
    }

    public void Reset()
    {
        _current = _current.List.First;
    }
    public void Dispose() {  } 
}

public static class CircularLinkedListExtensions
{
    public static LinkedListNode<T> Next<T>(
            this LinkedListNode<T> node)
        {
            if (node != null && node.List != null)
            {
            return node.Next ?? node.List.First;
            }
            return null;
        }
        public static LinkedListNode<T> Previous<T>(
                this LinkedListNode<T> node)
         {
            if (node != null && node.List != null)
            {
            return node.Previous ?? node.List.Last;
            }
            return null;
        }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<string> categories = new CircularLinkedList<string>();
        categories.AddLast("Educação Física");
        categories.AddLast("Cultura");
        categories.AddLast("Historia");
        categories.AddLast("Geografia");
        categories.AddLast("Pessoas");
        categories.AddLast("Tecnologia");
        categories.AddLast("Natureza");
        categories.AddLast("Ciências");


        Random random = new Random();
        int totalTime = 0;
        int remainingTime = 0;
        foreach (string category in categories)
        {
        if (remainingTime <= 0)
        {
            Console.WriteLine("Press [Enter] to start or any other to exit.");
            switch (Console.ReadKey().Key)
            {
            case ConsoleKey.Enter:
            totalTime = random.Next(1000, 5000);
            remainingTime = totalTime;
            break;
            default:
            return;
            }
            }
            int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
            remainingTime -= categoryTime;
            Thread.Sleep(categoryTime);
            Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(category);
            Console.ForegroundColor = ConsoleColor.Gray;
            }

    }
}
