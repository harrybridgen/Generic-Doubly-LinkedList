public class Program {
    static void Main(String[] args) {
        someLinkedList<int> linkedlist = new someLinkedList<int>();
        linkedlist.printList();
        linkedlist.append(2);
        linkedlist.printList();
        linkedlist.append(3);
        linkedlist.printList();
        linkedlist.printListReverse();
    }
}

