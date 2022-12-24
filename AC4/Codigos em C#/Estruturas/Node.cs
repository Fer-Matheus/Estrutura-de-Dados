namespace Codigos.Estruturas;

public class Node
{
    public int Key { get; set; } // Chave que servirá para organizar a tree
    public Object Obj { get; set; } // Conteúdo que será guardado nesse node
    public Node Left { get; set; } // Node à esquerda
    public Node Right { get; set; } // Node à direita
    public Node(int key, Object obj) // Construtor do Node
    {
        Key = key;
        Obj = obj;
        Left = null;
        Right = null;
    }
    public override string ToString() // Método para mostrar melhor o node
    {
        return $"Id: {Key}, Conteúdo: {Obj}";
    }
}
