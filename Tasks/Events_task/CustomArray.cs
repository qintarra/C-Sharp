using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayEvent
{  
    public class CustomArray<T> : IEnumerable<T>
    {
        /// <param name="sender">CustomArray parameter </param>
        /// <param name="e">ArrayEventArgs parameter</param>
        public delegate void ArrayHandler(object sender, ArrayEventArgs<T> e);
        /// <summary>
        /// Event that invokes when array element was changed 
        /// </summary>
        public event ArrayHandler OnChangeElement;

        /// <summary>
        /// Event that invokes when index of changed element equal to value 
        /// </summary>
        public event ArrayHandler OnChangeEqualElement;

        /// <summary>
        /// Should return first index of array
        /// </summary>
        public int First
        {
            get;
            private set;
        }

        /// <summary>
        /// Should return last index of array
        /// </summary>
        public int Last
        {
            get
            {
                return First + Length - 1;
            }
        }

        /// <summary>
        /// Should return length of array
        /// <exception cref="ArgumentException">Thrown when value was smaller than 0</exception>
        /// </summary>
        public int Length
        {
            get
            {
                return Array.Length;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Value is smaller than 0");
            }
        }

        /// <summary>
        /// Should return array 
        /// </summary>
        public T[] Array
        {
            get;
        }


        /// <summary>
        /// Constructor with first index and length
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="length">Length</param>         
        public CustomArray(int first, int length)
        {
            First = first;
            Length = length;
            Array = new T[length];
        }

        public CustomArray(int first, IEnumerable<T> list)
        {
            if (list == null)
                throw new NullReferenceException("NullReferenceException");
            if (list.ToArray().Length <= 0)
                throw new ArgumentException("ArgumentException");

            First = first;
            Array = list.ToArray();
        }

        public CustomArray(int first, params T[] list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "list is null");
            if (list.Length <= 0)
                throw new ArgumentException("ArgumentException");
            First = first;
            Array = list;
            Length = list.Length;
        }

        public T this[int item]
        {
            get
            {
                if (item < First || item > Last)
                    throw new ArgumentException("Index out of array range");
                return Array[item - First];
            }
            set
            {
                if (item < First || item > Last)
                    throw new ArgumentException("ArgumentException");
                if (value == null)
                    throw new ArgumentNullException(nameof(item), "index cannot be null");
                if (!value.Equals(this[item]))
                    OnChangeElement?.Invoke(this, new ArrayEventArgs<T>(item, "The element value was changed", value));
                if (value.Equals(item))
                    OnChangeEqualElement?.Invoke(this, new ArrayEventArgs<T>(item, "Value is equal to the index of the changed element", value));

                Array[item - First] = value;
            }
        }
              
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
