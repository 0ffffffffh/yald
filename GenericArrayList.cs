using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace yald
{
    [Serializable]
    public class GenericArrayList<T>
    {
        public delegate bool Iterator(T item);

        private ArrayList ArrList;

        public GenericArrayList(int capacity)
        {
            ArrList = new ArrayList(capacity);
        }

        public GenericArrayList()
        {
            ArrList = new ArrayList(25);
        }

        public int Add(T item)
        {
            return ArrList.Add(item);
        }

        public T this[int index]
        {
            get
            {
                return (T)ArrList[index];
            }
        }

        public int Count
        {
            get
            {
                return ArrList.Count;
            }
        }

        public void Clear()
        {
            ArrList.Clear();
        }

        public void Remove(T item)
        {
            ArrList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            ArrList.RemoveAt(index);
        }

        public void Iterate(Iterator iterator)
        {
            foreach (T item in ArrList)
            {
                if (iterator(item))
                    break;
            }
        }

        public IEnumerator GetEnumerator(int index, int count)
        {
            return ArrList.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ArrList.GetEnumerator();
        }
        
    }
}
