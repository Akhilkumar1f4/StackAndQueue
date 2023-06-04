
public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }

    public Node Next { get; internal set; }
    public int Data { get; internal set; }
}