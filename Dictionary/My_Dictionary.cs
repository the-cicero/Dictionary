using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class My_Dictionary<T1, T2, T3>
    {
        T1[] items1;
        T2[] items2;
        T3[] items3;
        public My_Dictionary()
        {
            items1 = new T1[0];
            items2 = new T2[0];
            items3 = new T3[0];
        }
        public void Add(T1 item1, T2 item2, T3 item3)
        {
            T1[] tempArray1 = items1;
            T2[] tempArray2 = items2;
            T3[] tempArray3 = items3;

            items1 = new T1[items1.Length];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }
            items1[items1.Length - 1] = item1;

            items2 = new T2[items2.Length];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }
            items2[items2.Length - 1] = item2;

            items3 = new T3[items3.Length];
            for (int i = 0; i < tempArray3.Length; i++)
            {
                items3[i] = tempArray3[i];
            }
            items3[items3.Length - 1] = item3;

        }
    }
}