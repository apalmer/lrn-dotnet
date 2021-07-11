using System;
using System.Collections.Generic;

namespace lib
{
    public class SimplePriorityQueue : IPriorityQueue
    {
        private class Item
        {
            public int Key { get; set; }
            public object Value { get; set; }
        }

        private List<Item> _items;

        public SimplePriorityQueue()
        {
            _items = new List<Item>();
        }

        public void InsertWithPriority(int priority, object value)
        {
            _items.Add(new Item() { Key = priority, Value = value });
            _items.Sort((x, y) => x.Key - y.Key);
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public object Peek()
        {
            return _items[0];   
        }

        public object RemoveHighestPriority()
        {
            if (IsEmpty())
            {
                throw new Exception("SimplePriorityQueue is empty");
            }

            var result = Peek();
            _items.RemoveAt(0);

            return result;
        }
    }
}
