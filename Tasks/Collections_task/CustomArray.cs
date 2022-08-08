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

        

    }
}
