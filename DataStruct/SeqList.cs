using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class SeqList<T> : IListDS<T>
    {
        private int maxsize; //顺序表容量
        private T[] data;  //数组用于存储数据表
        private int last;  //表示最后一个元素的位置

        //索引器
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public int Last
        {
            get { return last; }
        }

        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }

        public SeqList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }

        public bool IsFull()
        {
            if (last==maxsize-1)
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
            if (IsFull())
            {
                Console.WriteLine("list is full");
            }
            data[++last] = item;
        }

        public void Clear()
        {
            last = -1;
        }

        public T Delete(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return tmp;
            }

            if (i<1||i>last+1)
            {
                Console.WriteLine("Position is error");
                return tmp;
            }

            if (i==last+1)
            {
                tmp = data[last--];
            }
            else
            {
                tmp = data[i - 1];
                for (int j = i; j <= last; ++j)
                {
                    data[j] = data[j + 1];
                }
            }
            --last;
            return tmp;
        }

        public T GetElem(int i)
        {
            if (IsEmpty()||(i<1)||(i>last+1))
            {
                Console.WriteLine("List is empty or Position is error");
                return default(T);
            }
            return data[i - 1];
        }

        public int GetLength()
        {
            return last + 1;
        }

        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full");
                return;
            }
            if (i<1||i>last+2)
            {
                Console.WriteLine("Position is error");
                return;
            }
            if (i==last+2)
            {
                data[last + 1] = item;
            }
            else
            {
                for (int j = last; j >=i-1; --j)
                {
                    data[j + 1] = data[j];
                }
                data[i - 1] = item;
            }
            ++last;
            
        }

        public bool IsEmpty()
        {
            if (last==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 在顺序表中查找值为value的数据元素
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            int i = 0;
            for (i = 0; i < last; i++)
            {
                if (value.Equals(data[i]))
                {
                    break;
                }
            }
            if (i>last)
            {
                return -1;
            }
            return i;
        }
    }


  
}
