public class Tree
{
    Node top;

    public Node Top { get => top; set => top = value; }

    public void Add();
    public void AddRecursive();
    public void Print();
}

public class Node
{
    public int value;

    public Node left;
    public Node right;

    public void Node()
    {
            //constructor
    }


}