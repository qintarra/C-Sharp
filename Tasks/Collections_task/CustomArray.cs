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


        

    }
}
