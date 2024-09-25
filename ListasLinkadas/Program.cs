
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Page
{
    public string Content { get; set; }
}

class Progaram
{
    static void Main()
    {
    Page pageFirst = new Page() { Content = "Atualmente..."};
    Page pageSecond = new Page() { Content = "Teste..."};
    Page pageThird = new Page() { Content = "Agora..."};
    Page pageFourth = new Page() { Content = "Ainda..."};
    Page pageFifth = new Page() { Content = "Segunda Feira..."};
    Page pageSixth = new Page() { Content = "Poderia..."};

    LinkedList<Page> pages= new LinkedList<Page>();
    pages.AddLast(pageSecond);
    LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
    pages.AddLast(pageSixth);
    pages.AddFirst(pageFirst);
    pages.AddBefore(nodePageFourth, pageThird);
    pages.AddAfter(nodePageFourth, pageFifth);

    LinkedListNode<Page> current = pages.First;
    int number = 1;
    while (current != null)
    {
        Console.Clear();
        string numberString = $"- {number} -";
        int leadingSpaces = (90 - numberString.Length) / 2;
        Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
        Console.WriteLine();
        
        string content = current.Value.Content;
        for (int i = 0; i < content.Length; i += 90)
        {
            string line = content.Substring(i);
            line = line.Length > 90 ? line.Substring(0, 90) : line;
            Console.WriteLine(line);
        }


        Console.WriteLine();

        Console.Write(current.Previous != null
        ? "< PREVIOUS [P]" : GetSpaces(14));
        Console.Write(current.Next != null
        ? "[N] NEXT >".PadLeft(76) : string.Empty);
        Console.WriteLine();
        switch (Console.ReadKey(true).Key)
            {
            case ConsoleKey.N:
            if (current.Next != null)
            {
            current = current.Next;
            number++;
            }
            break;
            case ConsoleKey.P:
            if (current.Previous != null)
            {
            current = current.Previous;
            number--;
            }
            break;
            default:
            return;
            }
        }
    }

    private static string GetSpaces(int number)
    {
    string result = string.Empty;
    for (int i = 0; i < number; i++)
    {
    result += " ";
    }
    return result;
    }
}