namespace _03.RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException where T : IComparable<T>
    {
        private const string Message = "The entered value was not in the defined range!";

        private T start;
        private T end;

        public InvalidRangeException(T start, T end, Exception innerException = null)
            : base(Message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.start.CompareTo(value) > 0)
                {
                    throw new ArgumentException("The end of the range cannot be before its start!");
                }

                this.end = value;
            }
        }
    }
}
