public class Stack
{
    private Node? top;

    public void Push(int data)
    {
        Node newNode = new Node(data);

        if (top == null)
        {
            top = newNode;
        }
        else
        {
            newNode.Next = top;
            top = newNode;
        }
    }
}