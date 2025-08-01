public class someLinkedList<T> {

    private LinkedListNode? head;
    private LinkedListNode? tail;

    public class LinkedListNode {
        public T data { get; set; }
        public LinkedListNode? next { get; set; }
        public LinkedListNode? prev { get; set; }
        public LinkedListNode(T data) {
            this.data = data;
        }
    }

    public void append(T data) {
        LinkedListNode newNode = new LinkedListNode(data);
        if (tail == null) {
            head = newNode;
            tail = newNode;
        }
        else {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
    }

    public void prepend(T data) {
        LinkedListNode newNode = new LinkedListNode(data);
        if (head == null) {
            head = newNode;
            tail = newNode;
        }
        else {
            head.next = newNode;
            newNode.prev = head;
            head = newNode;
        }
    }

    public void printList() {
        if (head == null) {
            Console.WriteLine("Head is null");
            return;
        }

        LinkedListNode current = head;
        while (current != null) {
            Console.WriteLine(current.data);
            current = current.next;

        }
    }

    public void printListReverse() {
        if (tail == null) {
            Console.WriteLine("Tail is null");
            return;
        }

        LinkedListNode current = tail;
        while (current != null) {
            Console.WriteLine(current.data);
            current = current.prev;

        }
    }
}

