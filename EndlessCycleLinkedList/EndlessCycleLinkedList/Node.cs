﻿namespace EndlessCycleLinkedList
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
