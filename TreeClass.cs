public class Tree <T> : IComparable <T> where T : IComparable <T>
{
    private Node root;
    public class Node// создаем класс элемента списка
    {
        // обЪявляем поля
        public T value { get; set; }//добавляем автоматические св-ва
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(T value)
        {
            this.value = value;
        }
    }

    public int CompareTo (T value)
    {
        return this.CompareTo(value);
    }

    public void add (T value)
    {
        root = appendNode(root, value);
    }


    private Node appendNode (Node current, T value)
    {
        if (current == null)
        {
            return new Node (value);
        }

        int compare = value.CompareTo(value);
        if (compare < 0)
        {
           
           current.left = appendNode(current.left, value);
        }
        else if (compare > 0)
        {
            current.right = appendNode(current.right, value);
        }

        return current;
    }

    public bool Contains(T item)
    {
        Node current = root;
        while (current != null)
        {
            int result = current.value.CompareTo(item);
            if (result == 0)
                return true;
            if (result < 0)
                current = current.left;
            else
                current = current.right;
        }
        return false;
    }
}

