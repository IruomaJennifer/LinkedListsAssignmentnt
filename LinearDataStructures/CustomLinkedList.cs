// See https://aka.ms/new-console-template for more information


public class CustomLinkedList<T>
{
    public ListNode<T> Tail { get; set; }
    public ListNode<T> Head { get; set; }
    public int Count { get; set; } = 0;

    //public void AddNode(ListNode<T> node)
    //{
    //    if(Head is null)
    //    {
    //        Head = Tail = node;
    //    }
    //    else
    //    {
    //        var temp = Tail;
    //        Tail.NextNode = node;//tail = head here
    //        Tail = node;
    //        Tail.PreviousNode = temp;
    //    }
    //    Count++;
    //}

    public void AddItem(T item)
    {
        if(Head is null)
        {
            Head = Tail = new ListNode<T>(item);
        }
        else
        {
            var temp = Tail;
            var newNode= new ListNode<T>(item, temp);
            Tail.NextNode = newNode;
            Tail = newNode;
        }
        Count++;
    }

    public void AddFirst(ListNode<T> node)
    {
        if (Head is null)
        {
            Head = Tail = node;
        }
        else
        {
            var temp = Tail;
            Head = node;
            Tail.PreviousNode = temp;
          
        }
        Count++;
    }

    public void AddLast(ListNode<T> node)
    {
        if (Head is null)
        {
            Head = Tail = node;
        }
        else
        {
            var temp = Tail;
            Tail.NextNode = node;
            Tail = node;
            Tail.PreviousNode = temp;
        }
        Count++;
    }

    public void Remove(T item)
    {
        
        ListNode<T> current = Head;
        ListNode<T> previous = null;
            while (current != null)
            {
                if (Equals(current.Value,item))
                {
                    break;
                }
                previous = current;
                current = current.NextNode;
                
            }
        
            if (current != null)
            {
                RemoveNodeAt(current, previous);
            }
    }

    private void RemoveNodeAt(ListNode<T> current, ListNode<T> previous)
    {
        Count--;
        if (Count == 0)
        {
            Head = null;
            Tail = null;
        }else if (previous == null)
        {
            Head = current.NextNode;
        }
        else
        {
            previous.NextNode = current.NextNode;
        }

        if(ReferenceEquals(Tail, current))
        {
            Tail = previous;
        }
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public ListNode<T>? Find(T value)
    {
        var current = Head;
        
        while (current != null)
        {
            if (value.Equals(current.Value))
            {
                return current;
            }
            current= current.NextNode;
        }
        return null;
    }
}