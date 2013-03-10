using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Exeption
{
    public class InvalidRangeException<T> : ApplicationException
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        //Fields
        private T start;
        private T end;

        //Properties
        public T Start
        {
            get
            {
                return start;
            }
        }

        public T End
        {
            get
            {
                return end;
            }
        }

        //Constructors
        public InvalidRangeException(T start, T end)
            : this(null, null, start, end )
        {
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, null, start, end)
        {
        }

        public InvalidRangeException(string message, Exception innerException, T start, T end)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }
    }
}
