using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        int index;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
            this.index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                index++;
            }
            return hasNext;
        }
        public void Print()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException();
            }
            Console.WriteLine(this.elements[this.index]);
        }
        public bool HasNext()
        {
            if (index < elements.Count - 1)
            {
                return true;
            }
            return false;
        }
    }
}
