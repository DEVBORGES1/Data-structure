using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorredeHaoi
{
    public class TorreDeHanoi
    {
        public int ContadorDiscos { get; private set; }
        public int ContadorJogadas { get; private set; }
        public Stack<int> De { get; private set; }
        public Stack<int> Para { get; private set; }
        public Stack<int> Auxiliar { get; private set; }
        public event EventHandler<EventArgs> JogadaCompleta;
    }

    public TorreDeHanoi (int discos)
    {
        ContadorDiscos = discos;
        De = new Stack<int>();
        Para = new Stack<int>();
        Auxiliar = new Stack<int>();
        for (int i = 01; i <= discos; i++)
        {
            int tamanho = discos - i + 1;
            Para.Push(tamanho);
        }
    }
    public void Start()
    {
        Jogada(ContadorDiscos, De, Para, Auxiliar);
    }
    public void Jogada (int discos, Stack<int> de, Stack<int> para, Stack<int> auxiliar)
    {
        if (discos > 0)
        {
            Jogada(discos - 1, de, para, auxiliar);
            para.Push(de.Pop());
            ContadorJogadas++;
            JogadaCompleta?.Invoke(this, EventArgs.Empty);
            Jogada(discos - 1, auxiliar, para, de);
        }
    }

}


