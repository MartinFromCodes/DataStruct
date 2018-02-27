using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqList<int> La = new SeqList<int>(3);
            La.Append(3);
            La.Append(5);
            La.Append(6);

            SeqList<int> Lb = new SeqList<int>(4);
            Lb.Append(2);
            Lb.Append(4);
            Lb.Append(6);
            Lb.Append(9);
            SeqList<int> Lc= Merge(La, Lb);
            for (int i = 0; i <= Lc.GetLength()-1; i++)
            {
                Console.Write(Lc[i]+" ");
            }
            Console.Read();

        }

        public static SeqList<int> Merge(SeqList<int> La,SeqList<int> Lb)
        {
            SeqList<int> Lc = new SeqList<int>(La.Maxsize + Lb.Maxsize);
            int i = 0;
            int j = 0;
            int k = 0;

            while ((i<=(La.GetLength()-1))&&(j<=(Lb.GetLength()-1)))
            {
                if (La[i]<Lb[j])
                {
                    Lc.Append(La[i++]);
                }
                else
                {
                    Lc.Append(Lb[j++]);
                }
            }

            while (i<=(La.GetLength()-1))
            {
                Lc.Append(La[i++]);
            }
            while (j<=(Lb.GetLength()-1))
            {
                Lc.Append(Lb[j++]);
            }

            return Lc;
        }
            

    }
}
