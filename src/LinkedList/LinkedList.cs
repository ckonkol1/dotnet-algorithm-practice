namespace LinkedList;

public class LinkedList()
{
    public int Value;
    public LinkedList Next;

    public LinkedList(int value) : this()
    {
        this.Value = value;
        this.Next = null!;
    }

    public LinkedList(int value, LinkedList linkedList) : this(value)
    {
        this.Value = value;
        this.Next = linkedList;
    }
}