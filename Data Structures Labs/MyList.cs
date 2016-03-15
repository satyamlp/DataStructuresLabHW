using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Labs
{
    public class Node
    {
        public Node (int val, Node nextNode)
        {
            m_data = val;
            m_next = nextNode;
        }

        public Node Next 
        {
            get { return m_next; }
            set { m_next = value; }
        }

        public int Data
        {
            get { return m_data;  }
            set { m_data = value;  }
        }

       /* public void Delete()
        {
        }*/

        int m_data;
        Node m_next;
    }

    public class MyList
    {
        public MyList()
        {
            m_head = null;
            m_tail = null;
        }

        public void AddTail(int val)
        {
            if (m_head==null)
            {
                m_head = new Node(val, null);
                m_tail = m_head;
            }
            else
            {
                Node newNode = new Node(val, null);
                if (m_tail!=null)
                {
                    m_tail.Next = newNode;
                    m_tail = newNode; 
                }
            }
        }

        public int Length()
        {
            int len = 0;
            Node current = m_head;
            while (current!=null)
            {
                current = current.Next;
                len++;
            }
            return len;
        }

        public Node GetHeadNode()
        {
            return m_head;
        }

        public Node GetNext(Node nd)
        {
            if (nd!=null)
            {
                return nd.Next;
            }
            
            return null;
        }

        private Node m_head;
        private Node m_tail;
    }
}
