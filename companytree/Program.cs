using CompanyTree;

Tree<Person> company = new Tree<Person>();

company.Root = new Node<Person>()
{
    Data = new Person(100, "Thiago", "CEO"),
    Parent = null
};

company.Root.Children = new List<Node<Person>>()
{
  new Node<Person>()
  {
    Data = new Person(1, "Mary Fox", "Líder de Desenvolvimento"),
    Parent = company.Root
  },

  new Node<Person>()
  {
    Data = new Person(50, "John Smith", "Líder de Pesquisa"),
    Parent = company.Root
  },

  new Node<Person>()
  {
    Data = new Person(150, "Lily Smith", "Líder de Vendas"),
    Parent = company.Root
  }

};

company.Root.Children[2].Children = new List<Node<Person>>()
{
    new Node<Person>()
    {
        Data = new Person(30, "Anthony Black", "Especialista de Vendas"),
        Parent = company.Root.Children[2]
    }
};

company.PrintTree(company.Root);