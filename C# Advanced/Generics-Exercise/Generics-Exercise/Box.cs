using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Exercise
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Value = new List<T>();
        }

        public List<T> Value { get; set; }
        public int GreaterValuesThan(T targetItem)
        {
            int counter = 0;
            foreach (var item in this.Value)
            {
                if (item.CompareTo(targetItem) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void Swap(int a, int b)
        {
            bool IsInRange = a >= 0 && a < this.Value.Count &&
                b >= 0 && b < this.Value.Count;

            if (!IsInRange)
            {
                throw new InvalidOperationException("Values are not in range");
            }

            T tempValue = this.Value[a];
            this.Value[a] = this.Value[b];
            this.Value[b] = tempValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in this.Value)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }

            string result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
