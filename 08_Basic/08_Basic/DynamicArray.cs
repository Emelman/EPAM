using Interfaces;
using System;
using System.Collections.Generic;
using Utils;

namespace _08_Basic
{
    class A : IComparable<int>
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(A other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }
    }


    internal class DynamicArray<T> : IIndexable<T>, ISeries<T> where T : IComparable<T>, new()
    {
        int length;
        T[] arrayHolder;
        private int currentIndex;

        public DynamicArray()
        {
            Length = 0;
            arrayHolder = new T[8];
        }

        public DynamicArray(int capacity)
        {
            Length = 0;
            arrayHolder = new T[capacity];
        }

        public DynamicArray(T[] _array)
        {
            arrayHolder = _array;
            Length = _array.Length;
        }

        public T this[int index]
        {
            get
            {
                if (index >= arrayHolder.Length)
                {
                    throw new IndexOutOfRangeException("is out of range");
                }
                return arrayHolder[index];
            }
            set
            {
                if (index >= arrayHolder.Length)
                {
                    throw new IndexOutOfRangeException("is out of range");
                }
                arrayHolder[index] = value;
            }
        }

        public T GetCurrent()
        {
            if (currentIndex >= arrayHolder.Length) Reset();
            if (currentIndex < 0) return arrayHolder[0];
            return arrayHolder[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= arrayHolder.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value >= 0)
                {
                    length = value;
                }
            }
        }

        public int Capasity
        {
            get
            {
                return arrayHolder.Length;
            }
        }

        public void Add(T item)
        {
            int index = length;
            if (index >= Capasity)
            {
                IncreaseCapacity(Capasity * 2);
            }
            arrayHolder[index] = item;
            length++;
        }

        private void IncreaseCapacity(int newCapacity)
        {
            T[] temp = new T[newCapacity];
            arrayHolder.CopyTo(temp, 0);
            arrayHolder = temp;
        }

        public void AddRange(T[] items)
        {
            int index = ArrayUtils.GetLastIndex(arrayHolder);
            if (Length + items.Length >= Capasity)     // one position reserved
            {
                IncreaseCapacity(Capasity + items.Length);
                items.CopyTo(arrayHolder, length);
            }
            else
            {
                items.CopyTo(arrayHolder, length);
            }
            length += items.Length;
        }

        public void Incert(T item, int index)
        {
            if(index >= Capasity)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            T[] part2 = new T[Capasity - index];
            Array.Copy(arrayHolder, index, part2, 0, part2.Length);
            T[] part1 = new T[index + 1];
            Array.Copy(arrayHolder, part1, index);
            part1[index] = item;
            arrayHolder = ArrayUtils.ExpandToArrayLengthSum(part1, part2);
            length++;
        }

        public bool Remove(int index)
        {
            if (index > Length && index < 0)
            {
                return false;
            }
            T[] part2 = new T[Capasity - index];
            Array.Copy(arrayHolder, index + 1, part2, 0, part2.Length - 1);
            T[] part1 = new T[index];
            Array.Copy(arrayHolder, part1, index);
            arrayHolder = ArrayUtils.ExpandToArrayLengthSum(part1, part2);
            length--;
            return true;
        }

        public void RemoveAt(T item)
        {
            var index = Array.IndexOf(arrayHolder, item);
            if (index >= 0)
            {
                Remove(index);
            }
            else
            {
                throw new ArgumentException("Cant find you argument!");
            }
        }

        public void Sort()
        {
            T temp = default;
            for (int write = 0; write < Length; write++)
            {
                for (int sort = 0; sort < Length - 1; sort++)
                {
                    if (arrayHolder[sort].CompareTo(arrayHolder[sort + 1]) == 1)
                    {
                        temp = arrayHolder[sort + 1];
                        arrayHolder[sort + 1] = arrayHolder[sort];
                        arrayHolder[sort] = temp;
                    }
                }
            }

        }

    }
}