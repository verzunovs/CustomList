namespace MyList
{
    using System.Collections;

    // using System.Collections.Generic;
    public class CustomList<T>
    {
        private T[] list;
        private int count = 0;
        private int capacity = 0;

        public int Count => this.count;

        public int Capacity => this.capacity;

        public void Add(T item)
        {
            this.count++;
            T[] temp = new T[this.count];
            if (this.list != null)
            {
                for (var i = 0; i < this.list.Length; i++)
                {
                    temp[i] = this.list[i];
                }
            }

            temp[this.count - 1] = item;
            this.list = temp;
        }

        private void ExpandList()
        {
            if (this.IsFull())
            {
            }
        }

        private bool IsFull()
        {
            if (this.list[this.list.Length - 1] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
