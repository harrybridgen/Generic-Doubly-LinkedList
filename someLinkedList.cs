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
            head.prev = newNode;
            newNode.next = head;
            head = newNode;
        }
    }

    public void removeHead() {
        
        if (head == null) {
            Console.WriteLine("[removeHead] ERROR: head is null");
            return;
        }
        LinkedListNode oldHead = head;
        if (oldHead.Equals(tail)) {
            tail = null;
            head = null;
            oldHead.next = null;
            oldHead.prev = null;
        } 
        else {
            head = oldHead.next;
            head.prev = null;
        }
            
        oldHead.prev = null;
        oldHead.next = null;
    }

    public void removeTail() {
        if (tail == null) {
            Console.WriteLine("[removeTail] ERROR: tail is null");
            return;
        }
        LinkedListNode oldTail = tail;
        if (oldTail.Equals(head)) {
            tail = null;
            head = null;
            oldTail.next = null;
            oldTail.prev = null;
        }
        else {
            tail = oldTail.prev;
            tail.next = null;
        }
        oldTail.prev = null;
        oldTail.next = null;
    }

    public void printList() {
        if (head == null) {
            Console.WriteLine("[]");
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
            Console.WriteLine("[]");
            return;
        }

        LinkedListNode current = tail;
        while (current != null) {
            Console.WriteLine(current.data);
            current = current.prev;

        }
    }
}

