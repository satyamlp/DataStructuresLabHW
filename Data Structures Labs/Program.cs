using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Labs
{
    class Program
    {
        public static void TestSmoosh()
        {
            //int[] ints = { 0, 0, 0, 0, 1, 1, 0, 0, 0, 3, 3, 3, 1, 1, 0 };
            //int[] ints = { 0, 0, 1, 2, 3, 1, 1, 0, 0, 3, 3, 3, 1, 1, 0 };
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 13 };
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16 };
            int[] ints = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //int[] ints = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 1, 1, 4, 1, 1, 0 };

            int len = ints.Count();
            Console.WriteLine("Before smoosh values in the array with length = {0} are.............", len);
            
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("{0}", ints[i]);
            }

            
            Lab2.smoosh(ints);
            len = ints.Count();
            Console.WriteLine("After smoosh values in the array with length = {0} are.............", len);
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("{0}", ints[i]);
            }

            Console.WriteLine();
        }

        public static void TestSquish()
        {
            MyList list = new MyList();
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(1);
            list.AddTail(1);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(3);
            list.AddTail(3);
            list.AddTail(3);
            list.AddTail(1);
            list.AddTail(1);
            list.AddTail(0);

            Console.WriteLine("Before squish values are...........");
            Node currentNode = list.GetHeadNode();
            while (currentNode!=null)
            {
                Console.WriteLine("{0}", currentNode.Data);
                currentNode = currentNode.Next;
            }

            // Call the method
            LabList.squish(list);

            Console.WriteLine("After squish values are, length = {0}.............", list.Length());
            currentNode = list.GetHeadNode();
            while (currentNode != null)
            {
                Console.WriteLine("{0}", currentNode.Data);
                currentNode = currentNode.Next;
            }
            //Console.WriteLine("New list Length is {0}", list.Length());
        }

        static void Main(string[] args)
        {
            TestSmoosh();
            TestSquish();
            Console.ReadLine();
        }
    }
}
