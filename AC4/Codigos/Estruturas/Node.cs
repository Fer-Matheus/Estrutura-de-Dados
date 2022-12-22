namespace Codigos.Estruturas;

public class Node
{
    public int Key { get; set; }
    public Object Obj { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node(int key, Object obj)
    {
        Key = key;
        Obj = obj;
        Left = null;
        Right = null;
    }
    public override string ToString()
    {
        return $"Id: {Key}, Conteúdo: {Obj}";
    }
}
