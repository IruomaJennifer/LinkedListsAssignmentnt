// See https://aka.ms/new-console-template for more information

CustomLinkedList<int> check = new CustomLinkedList<int>();
check.AddItem(1);
check.AddItem(2);
check.AddItem(3);
check.AddItem(4);
Console.WriteLine(check.Tail.Value);

check.AddLast(new ListNode<int>(10));
Console.WriteLine(check.Tail.Value);

check.AddFirst(new ListNode<int>(20));
Console.WriteLine(check.Head.Value);
Console.WriteLine(check.Count);

check.Remove(4);
Console.WriteLine(check.Tail.PreviousNode.Value);