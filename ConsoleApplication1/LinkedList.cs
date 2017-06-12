using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinkedList
    {
        Node head;
        int listLength = 0;
        Random rnd = new Random();
        

        class Node
        {
            public Node next;
            public Card data;


            public Node(Card data)
            {
                this.data = data;
            }




        }

        public void addValue(Card data)
        {
            Node current = head;


            if (head == null)
            {
                head = new Node(data);
                listLength++;
                return;
            }

            while (current.next != null)
            {

                current = current.next;

            }
            current.next = new Node(data);
            listLength++;

        }
        public int getListLength()
        {
            return listLength;
        }
        public void printValues()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine("|" + current.data + "|");

                current = current.next;

            }
        }
        public bool findValue(Card data)
        {
            Node current = head;


            while (current != null)
            {
                if (current.data == data)
                {
                    return true;

                }
                else
                {
                    current = current.next;
                }
            }

            return false;
        }
        public void removeValue(Card value)
        {
            Node current = head;
            Node prev = null;

            if (head.data == value)
            {
                head = head.next;
                listLength--;
            }
            while (current != null)
            {
                if (current.data == value)
                {
                    break;
                }
                prev = current;
                current = current.next;
            }
            if (current != null)
            {
                prev.next = current.next;
                listLength--;
            }



        }
        public Card drawCard()
        {
            if(head == null)
            {
                return null;
            }

            Node current = head;
           

           removeValue(head.data);
            
            
            return current.data;  
            
        }
        
        public Card GetIndex(int index)
        {
            if (index > listLength || index < 0)
                return null;

            Node current = head;

            for(int i = 1; i <= index; i++)
            {
                current = current.next;
            }

            return current.data;
        }
        public void shuffleList ()
        {
            Node current = head;

            for (int i = 0;i<listLength-1;i++)
            {
               
                int index = rnd.Next(listLength - i); //get a random number


                //Card tempSuit = new Card();
                //Card tempValue = new Card();

                //tempSuit.setSuit(current.data.getSuit());
                //tempValue.setValue(current.data.getValue());

                //current.data.setSuit(GetIndex(index).getSuit());
                //current.data.setValue(GetIndex(index).getValue());

                //GetIndex(index).setSuit(tempSuit.getSuit());
                //GetIndex(index).setValue(tempSuit.getValue());

                Card b = GetIndex(index);

                Card temp = current.data;
                current.data = b;
                b = temp;



                //swap(ref current.data, ref b); // swap cards

                current = current.next; //increase the head position by 1
                
            }

            
        }
        public void swap (ref Card a,ref Card b)
        {
            
            //Card temp = b;
            //b = a;
            //a = temp;
        }

    }

}
