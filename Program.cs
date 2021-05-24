using System;

namespace reitLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("-------------------- Iterative --------------------");
            list.iterate();
            Console.WriteLine("-------------------- Recursive --------------------");
            list.recurse(6);
        }
    }

    class LinkedList
    {
        // Create linked list and start pointer
        int[,] list = {{2,1}, {3,3}, {1,0}, {5,4}, {6,5}, {9,7}, {0,2}, {10,-1}};
        int pointer = 6;

        public void iterate()
        {
            while (true)
            {
                // Return data at index in linked list, then pointer = next pointer
                Console.WriteLine(list[pointer,0]);
                pointer = list[pointer,1];

                // If the pointer doesn't point to a value, reset the start pointer and stop iterating
                if (pointer == -1)
                {
                    pointer = 6;
                    break;
                }
            }
        }

        public int recurse(int point)
        {
            // Return data at index in linked list, then pointer = next pointer
            Console.WriteLine(list[pointer,0]);
            pointer = list[pointer,1];

            // If pointer doesn't point to a value, reset the start pointer and stop recursing
            if (pointer == -1)
            {
                pointer = 6;
                return -1;
            }

            // Otherwise recurse again
            return recurse(pointer);
        }
    }
}
