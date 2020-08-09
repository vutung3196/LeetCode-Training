namespace LinkedListImplementation
{
    public class MyLinkedList
    {
        internal Node HeadNode { get; set; }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            // The current node should be head node
            var current = HeadNode;
            var length = Length();
            if (index >= length)
            {
                return -1;
            }

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Val;
        }

        private int LengthOfList => Length();

        public int Length()
        {
            var current = HeadNode;
            var count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        /** Add a node of value val before the first element of the linked list.
         * After the insertion, the new node will be the first node of the linked list.
         */
        public void AddAtHead(int val)
        {
            var newNode = new Node(val);
            if (HeadNode == null)
            {
                HeadNode = newNode;
                return;
            }
            newNode.Next = HeadNode;
            HeadNode = newNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var finalNode = GetCurrentNode(Length() - 1);
            var newNode = new Node(val);
            if (finalNode == null)
            {
                HeadNode = newNode;
                return;
            }

            finalNode.Next = newNode;
        }

        public Node GetCurrentNode(int index)
        {
            var current = HeadNode;
            var count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    return current;
                }

                count++;
                current = current.Next;
            }

            return null;
        }

        /** Add a node of value val before the index-th node in the linked list.
         * If index equals to the length of linked list, the node will be appended to the end of linked list.
         * If index is greater than the length, the node will not be inserted.
         */
        public void AddAtIndex(int index, int val)
        {
            var lengthOfLinkedList = Length();
            if (index > lengthOfLinkedList)
            {
                return;
            }

            if (index == lengthOfLinkedList)
            {
                AddAtTail(val);
                return;
            }

            if (index <= 0)
            {
                AddAtHead(val);
                return;
            }

            var currentNode = HeadNode;
            for (var i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }

            var node = new Node(val);
            node.Next = currentNode.Next;
            currentNode.Next = node;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var lengthOfLinkedList = Length();
            if (index >= lengthOfLinkedList)
            {
                return;
            }

            if (index == 0)
            {
                HeadNode = HeadNode.Next;
                return;
            }

            var currentNode = HeadNode;
            for (var i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = currentNode.Next.Next;
        }
    }

    public class Node
    {
        internal int Val { get; set; }
        internal Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
            Next = null;
        }
    }
}