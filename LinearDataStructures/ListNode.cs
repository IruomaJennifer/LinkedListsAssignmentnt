// See https://aka.ms/new-console-template for more information
public class ListNode<T>
{
    public ListNode(T currentValue,ListNode<T> previousValue,ListNode<T> nextValue):this(currentValue,previousValue)
    {
        NextNode = nextValue;
    }
    public ListNode(T value,ListNode<T> previousNode):this(value)
    {
        PreviousNode = previousNode;
    }
    public ListNode(T value)
    {
        Value = value;
    }
    public T Value { get; set; }
    public ListNode<T> PreviousNode { get;  set; }
    public ListNode<T> NextNode { get;  set; }
}
