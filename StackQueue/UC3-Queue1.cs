public class Queue
{
    private Node? front;
    private Node? rear;

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);

        if (rear == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
    }
}
