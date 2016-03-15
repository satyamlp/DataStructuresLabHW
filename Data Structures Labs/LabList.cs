using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Labs
{
    public class LabList
    {
        /// Create your own definition of linkedlist first 

        /// squish() takes your linked list and, wherever two or more consecutive items are 

        /// equals(), it removes duplicate nodes so that only one consecutive copy 

        /// remains.  Hence, no two consecutive items in this list are equals() upon 

        /// completion of the procedure. 

        ///  

        /// After squish() executes, the list may well be shorter than when squish()    

        /// began.  No extra items are added to make up for those removed.  

        /// For example, if the input list is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ], the   

        /// output list is [ 0 1 0 3 1 0 ]. 

        /// </summary> 

        public static void squish(MyList list)
        {
            if (list == null)
                throw new System.ArgumentNullException();

            Node currentNode = list.GetHeadNode();
            Node nextNode = null;
            int data = 0;
            
            while (currentNode!=null)
            {
                data = currentNode.Data;
                nextNode = currentNode.Next;

                if (nextNode == null)
                {
                    // next node is null. no more data to check. exit
                    break;
                }

                if (data == nextNode.Data)
                {
                    // duplicate found, move to the next one and delete the duplicate
                    currentNode.Next = nextNode.Next;
                    //tempNode = null;
                    //Console.WriteLine("remove next node with data {0}, current node data {1}", data, currentNode.Data);
                }
                else
                {
                    // no duplicate, go to the next one 
                    currentNode = nextNode;
                    //Console.WriteLine("current node data {0}, next node data {1}", currentNode.Data, nextNode.Data);
                }
            }
        }
    }
}
