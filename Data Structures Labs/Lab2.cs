using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Labs
{
    public class Lab2
    {
        /// <summary> 

        /// smoosh() takes an array of ints.  On completion the array contains    
        /// the same numbers, but wherever the array had two or more consecutive 
        /// duplicate numbers, they are replaced by one copy of the number.Hence,    
        /// after smoosh() is done, no two consecutive numbers in the array are the    
        /// same. 

        ///  

        /// Any unused elements at the end of the array are set to -1.    

        ///   

        /// For example, if the input array is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ],    

        /// it reads[0 1 0 3 1 0 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1] after smoosh() 

        /// completes. 

        /// </summary> 

        /// <param name="ints">the input array</param> 

        public static void smoosh(int[] ints)
        {
            if (ints == null)
                throw new System.ArgumentNullException();

            // Fill in your solution here.
            int len = ints.Count();
            int i = 0;
            int insertIndex = 0;
            while (i<len)
            {
                int startPos = i;
                int elementCounter = 0;

                int ele = ints[startPos];
                int j = startPos + 1;
                while (j< len)
                {
                    if (ele==ints[j])
                    {
                        elementCounter++;
                    }
                    else
                    {
                        // no more duplciates, exit this loop
                        break;
                    }
                    j++;
                }

                if (elementCounter>0)
                {
                    // there are some duplicates elements. insert only 1 of those
                    ints[insertIndex] = ele;
                    i = i + elementCounter + 1;
                    insertIndex++;
                }
                else
                {
                    // no duplicates. just copy the next element
                    ints[insertIndex] = ele;
                    i++;
                    insertIndex++;
                }
            }
            
            // pad with -1s
            while (insertIndex<len)
            {
                ints[insertIndex] = -1;
                insertIndex++;
            }   
        }
    }
}
