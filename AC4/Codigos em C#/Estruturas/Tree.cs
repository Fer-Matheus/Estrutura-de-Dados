namespace Codigos.Estruturas;
public class Tree
{
    public Node Root { get; set; }
    public Tree()
    {
        Root = null;
    }
    public bool Insert(int id, Object obj)
    {
        if (Root == null)
        {
            Root = new Node(id, obj);
            return true;
        }
        else
        {
            if (id < Root.Key)
            {
                Root.Left = InsertAux(id, obj, Root.Left);
                if (Root.Left != null) return true;
            }
            else if (id > Root.Key)
            {
                Root.Right = InsertAux(id, obj, Root.Right);
                if (Root.Right != null) return true;
            }
            return false;
        }
    }

    private Node InsertAux(int id, object obj, Node root)
    {
        if (root == null)
        {
            root = new Node(id, obj);
            return root;
        }
        else if (id < root.Key)
        {
            root.Left = InsertAux(id, obj, root.Left);
            return root;
        }
        else if (id > root.Key)
        {
            root.Right = InsertAux(id, obj, root.Right);
            return root;
        }
        return null;
    }
    public void Show(String mode)
    {
        if (mode == "C")
        {
            ShowCres(Root);
        }
        else if (mode == "D")
        {
            ShowDecres(Root);
        }
        else
        {
            ShowLayer(Root);
        }
        System.Console.WriteLine();
    }

    private void ShowLayer(Node root)
    {
        if (root != null)
        {
            System.Console.WriteLine(root);
            ShowLayer(root.Left);
            ShowLayer(root.Right);
        }
    }

    private void ShowDecres(Node root)
    {
        if (root != null)
        {
            ShowDecres(root.Right);
            System.Console.WriteLine(root);
            ShowDecres(root.Left);
        }
    }

    private void ShowCres(Node root)
    {
        if (root != null)
        {
            ShowCres(root.Left);
            System.Console.WriteLine(root);
            ShowCres(root.Right);
        }
    }
    public bool Search(int idNode)
    {
        if (Root != null)
        {
            return SearchAux(idNode, Root);
        }
        return false;
    }

    private bool SearchAux(int idNode, Node root)
    {
        if (root != null)
        {

            if (idNode == root.Key) return true;
            if (idNode < root.Key)
            {
                return SearchAux(idNode, root.Left);
            }
            else if (idNode > root.Key)
            {
                return SearchAux(idNode, root.Right);
            }
            return false;
        }
        return false;
    }
    public void Delete(int idNode){
        if(Root != null){
            Root = DeleteAux(idNode, Root);
        }
    }

    private Node DeleteAux(int idNode, Node root)
    {
        if(idNode == root.Key){
            Node left = root.Left;
            Node right = root.Right;
            left = InsertAuxDel(left,right);
            return left;
        }
        if(idNode < root.Key){
            root.Left = DeleteAux(idNode, root.Left);
            return root;
        }
        else if(idNode > root.Key){
            root.Right = DeleteAux(idNode, root.Right);
            return root;
        }
        return null;
    }
    private Node InsertAuxDel(Node root, Node node)
    {
        if(root == null) return node;
        if(node.Key<root.Key){
            root.Left = InsertAuxDel(root.Left, node);
            return root;
        }else if(node.Key > root.Key){
            root.Right = InsertAuxDel(root.Right, node);
            return root;
        }
        return null;
    }
}
