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

        public void Insert(int index, T item)
        {
            if (this.list != null)
            {
                if (index < this.list.Length)
                {
                    this.count++;
                    T[] temp = new T[this.count];
                    for (var i = 0; i < this.list.Length; i++)
                    {
                        temp[i] = this.list[i];
                    }

                    this.list = temp;
                    for (int i = 0; i < this.list.Length; i++)
                    {
                        if (i == index)
                        {
                            int lastElement = this.list.Length - 1;
                            for (int j = this.list.Length - 1; j >= i; j--)
                            {
                                this.list[j] = this.list[j - 1];
                            }

                            this.list[i] = item;
                            break;
                        }
                    }

                    this.list[index] = item;
                }
            }
        }
    }
}
