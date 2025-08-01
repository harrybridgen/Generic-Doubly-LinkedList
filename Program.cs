public class Program {
    static void Main(String[] args) {
        someLinkedList<int> linkedlist = new someLinkedList<int>();
        linkedlist.append(1);
        linkedlist.append(2);
        linkedlist.append(3);
        linkedlist.append(4);
        linkedlist.append(5);
        linkedlist.printList();
        Console.WriteLine("");
        linkedlist.removeHead();
        linkedlist.removeTail();
        linkedlist.printList();
        Console.WriteLine("");
        linkedlist.removeHead();
        linkedlist.removeTail();
        linkedlist.printList();
        Console.WriteLine("");
        linkedlist.removeTail();
        linkedlist.printList();
    }
}

