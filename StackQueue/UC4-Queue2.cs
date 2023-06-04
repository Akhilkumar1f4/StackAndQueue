public class Queue1
{
    private Node? front;
    private Node? rear;

    public int Dequeue()
{
    if (front == null)
    {
        throw new InvalidOperationException("Queue is empty");
    }

    int data = front.Data;
    front = front.Next;

    if (front == null)
    {
        rear = null;
    }

    return data;
}

public bool IsEmpty()
{
    return front == null;
}
}