using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Final_Project
{
    public class SinglyLinkedList
    {
        public Node head;
        public class Node
        {
            public string data;
            public Node next;
            public Node(string d) { data = d; next = null; }
        }
        public void push(string new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void append(string new_data)
        {
            Node new_node = new Node(new_data);

            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;
            Node last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
            return;
        }
        public void deleteNode(string key)
        {
            Node traveler = head, prev = null;

            if (traveler != null &&
                traveler.data == key)
            {
                head = traveler.next;
                return;
            }

            while (traveler != null &&
                   traveler.data != key)
            {
                prev = traveler;
                traveler = traveler.next;
            }

            if (traveler == null)
                return;

            prev.next = traveler.next;
        }
        public void pop()
        {
            string file = "C:\\Folder\\File.txt";

            FileStream stream = File.Create(file);
            StreamWriter sw = new StreamWriter(stream);


            Node traveler = head;

            while (traveler != null)
            {
                sw.WriteLine(traveler.data);
                traveler = traveler.next;
            }
            sw.Close();
        }


    }
}
