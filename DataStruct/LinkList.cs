using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> head; //单链表的头引用
        
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        //构造器
        public LinkList()
        {
            head = null;
        }

        public int GetLength()
        {
            Node<T> p = head;
            int len = 0;
            while (p!=null)
            {
                ++len;
                p = p.Next;
            }
            return len;
            
        }
        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();
            if (head==null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.Next!=null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        //在单链表的第i个结点的位置前插入一个值为item的结点
        public void Insert(T item, int i)
        {
            if (IsEmpty()||i<1)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if (i==1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head;
                head = q;
                return;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.Next!=null&&j<i)
            {
                r = p;
                p = p.Next;
                ++j;
            }

            if (j==i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p;
                r.Next = q;
            }
        }

        //在单链表的第i个结点的位置后插入一个值为item的结点
        public void InsertPost(T item ,int i)
        {
            if (IsEmpty()||i<1)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if (i==1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 1;
            while (p!=null&&j<i)
            {
                p = p.Next;
                ++j;
            }
            if (j==i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
        }
        public T Delete(int i)
        {
            if (IsEmpty()||i<0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i==1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }

            Node<T> p = head;
            int j = 1;
            while (p.Next!=null&&j<i)
            {
                ++j;
                q = p;
                p = p.Next;
            }

            if (j==i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }

        }

        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.Next!=null&&j<i)
            {
                ++j;
               p= p.Next;
            }

            if (j==i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }
         
        //在单链表中查找值为value的结点
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(value)&&p.Next!=null)
            {
                p=p.Next;
                ++i;
            }
            return i;
        }
    }


}
