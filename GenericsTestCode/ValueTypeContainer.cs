﻿using System;
using System.Collections.Generic;


namespace GenericsTestCode
{
    public class ValTypeCont<T> where T : struct
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Out of range.");
            }
        }

        public List<T> SortInDescinding()
        {
            List<T> sortedList = new List<T>(items);
            sortedList.Sort();
            sortedList.Reverse();
            return sortedList;
        }
    }
}
