using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomArray
{
    public class CustomArray<T> 
    {
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

        /// <summary>
        /// Constructor with first index and collection  
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="list">Collection</param>
        ///  <exception cref="NullReferenceException">Thrown when list is null</exception>
        /// <exception cref="ArgumentException">Thrown when count is smaler than 0</exception>       
        public CustomArray(int first, IEnumerable<T> list)
        {
            if (list == null)
                throw new NullReferenceException("NullReferenceException");
            if (list.ToArray().Length <= 0)
                throw new ArgumentException("ArgumentException");

            First = first;
            Array = list.ToArray();
        }

        /// <summary>
        /// Constructor with first index and params
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="list">Params</param>
        ///  <exception cref="ArgumentNullException">Thrown when list is null</exception>
        /// <exception cref="ArgumentException">Thrown when list without elements </exception>
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

        /// <summary>
        /// Indexer with get and set  
        /// </summary>
        /// <param name="item">Int index</param>        
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when index out of array range</exception>  
        /// <exception cref="ArgumentNullException">Thrown in set  when value passed in indexer is null</exception>       
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
                if (Array[item - First] == null)
                    throw new ArgumentNullException(nameof(item), "index cannot be null");
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

        
    }
}
