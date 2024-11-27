using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree
{
    public class Node<T>
    {
        public T? Data { get; set; }
        public Node<T>? Parent { get; set; }
        public List<Node<T>>? Children { get; set; } = new List<Node<T>>();

        public int GetHeight()
        {
            int height = 1;
            Node<T> current = this;

            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}