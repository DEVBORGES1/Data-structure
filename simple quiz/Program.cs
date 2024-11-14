using SimpleQuiz;

    BinaryTree<QuizItem> tree = GetTree();
    BinaryTreeNode<QuizItem> node = tree.Root;

    while (node != null)
    {
        // Exibe a pergunta atual
        Console.WriteLine(node.Data.Text);

        // Se o nó atual possui filhos, aguarda resposta do usuário
        if (node.Left != null || node.Right != null)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine(" Sim");
                    node = node.Left;
                    break;
                case ConsoleKey.N:
                    Console.WriteLine(" Não");
                    node = node.Right;
                    break;
            }
        }
        else
        {
            // Se o nó não tem filhos, exibe a resposta final e encerra
            Console.WriteLine(node.Data.Text);
            node = null;
        }
    }

static BinaryTree<QuizItem> GetTree()
{
    var tree = new BinaryTree<QuizItem>();

    // Raiz da árvore
    tree.Root = new BinaryTreeNode<QuizItem>
    {
        Data = new QuizItem("Tu é bom em programação?"),
        Left = new BinaryTreeNode<QuizItem>
        {
            Data = new QuizItem("Trabalhou ou estudou com programação a mais de 1 ano?"),
            Left = new BinaryTreeNode<QuizItem>
            {
                Data = new QuizItem("Já é sabidão então!")
            },
            Right = new BinaryTreeNode<QuizItem>
            {
                Data = new QuizItem("Tá quase bão!")
            }
        },
        Right = new BinaryTreeNode<QuizItem>
        {
            Data = new QuizItem("Terminou um curso ou universidade?"),
            Left = new BinaryTreeNode<QuizItem>
            {
                Data = new QuizItem("Tu é iniciante garotinho!")
            },
            Right = new BinaryTreeNode<QuizItem>
            {
                Data = new QuizItem("Vc se encontrou na área da computação?"),
                Left = new BinaryTreeNode<QuizItem>
                {
                    Data = new QuizItem("Aizaaa já é maluco na área então kkkkkk!")
                },
                Right = new BinaryTreeNode<QuizItem>
                {
                    Data = new QuizItem("Vishh, ta mais perdido que cego kkkkkk!")
                }
            }
        }
    };
    return tree;
}