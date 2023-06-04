public class Stack1
{
    private Node? top;

    public int Pop()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int data = top.Data;
        top = top.Next;
        return data;
    }

    public int Peek()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}