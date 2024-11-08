using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace DEQUE_CARD_SHUFFLER
{
    internal class Program
    {
        Queue<object> cards = new Queue<object>();
        static void Main(string[] args)
        {
            new Program();
            ReadLine();
        }
        public Program()
        {
            readCards();
            Shuffle();
            Display();
        }
        public void Display()
        {
            Node temp = head;
            while(temp!=null)
            {
                WriteLine(temp.cargo);
                temp=temp.Next;
            }
        }
        public void readCards()
        {
            StreamReader sr = new StreamReader("Cards.txt");
            while(!sr.EndOfStream)
            {
                string line=sr.ReadLine();
                cards.Enqueue(line);
            }
        }
        public void Shuffle()
        {
            // Continue looping while there are cards in the queue
            while (cards.Count > 0)
            {
                int length = cards.Count;  // Get the current count of cards in the queue
                for (int n = 1; n <= length; n++) // Start from 1
                {
                    // Add cards to front if odd, to back if even
                    if (n % 2 != 0)  // ODD
                    {
                        int i = n;
                        while (i > 0 && cards.Count > 0) // Ensure there's a card to dequeue
                        {
                            object o = cards.Dequeue();
                            EnqueueFront(o);  // Add to front of the list
                            //WriteLine("ODD");
                            i--;
                        }
                    }
                    else  // EVEN
                    {
                        int i = n;
                        while (i > 0 && cards.Count > 0) // Ensure there's a card to dequeue
                        {
                            object o = cards.Dequeue();
                            EnqueueBack(o);  // Add to back of the list
                           // WriteLine("EVEN");
                            i--;
                        }
                    }
                    // Stop the loop if there are no more cards left
                    if (cards.Count == 0)
                    {
                        break;
                    }
                }
            }
        }

        Node head, tail;
        int count = 0;
        public void EnqueueFront(Object o)
        {
            Node newNode = new Node(o);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            count++;
        }
        public void EnqueueBack(Object o)
        {
            Node newNode = new Node(o);
            if (tail == null)
            {
                tail = newNode;
                head = newNode;
            }
            else
            {
                EnqueeBackRec(tail, newNode);
                tail = newNode;
            }
            count++;
        }
        private void EnqueeBackRec(Node current, Node newNode)
        {
            //base case:if we reach the tail insert at the end 
            if (current.Next == null)
            {
                current.Next = newNode;
                newNode.Prev = current;
            }
            else
            {
                EnqueeBackRec(current.Next, newNode);
            }
        }
        public Object DequeueFront()
        {
            if (head.Next == null)
            {
                object temp = head.cargo;
                head = null;
                tail = null;
                return temp;
            }
            else
            {
                Node temp = head;
                temp.Next = head;
                temp.Prev = null;
                return temp.cargo;
            }
            count--;
        }
        public Object DequeueBack()
        {
            if (tail.Next == null)
            {
                Node temp = tail;
                tail = null;
                head = null;
                return temp.cargo;
            }
            else
            {
                Node temp = tail;
                temp.Prev = tail;
                temp.Prev.Next = null;
                tail = null;
                return temp.cargo;
            }
            count--;
        }
        public Object PeekFront()
        {
            return head.cargo;
        }
        public Object PeekBack()
        {
            return tail.cargo;
        }
        public int Count()
        {
            return count;
        }
    }
    class Node
    {
        public Node Next, Prev;
        public object cargo;
        public Node(object data)
        {
            this.cargo = data;
        }
    }
    class Quee
    {
        
    }
}
