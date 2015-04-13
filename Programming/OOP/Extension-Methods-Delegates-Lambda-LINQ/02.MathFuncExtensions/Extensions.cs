namespace _02.MathFuncExtensions
{
    using System;
    using System.Collections.Generic;

    static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 0;

            foreach (T element in enumeration)
            {
                sum += (dynamic)element;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product = 1;

            foreach (T element in enumeration)
            {
                product *= (dynamic)element;

                if (product == 0)
                {
                    break;
                }
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
        {
            dynamic minValue = int.MaxValue;

            foreach (T element in enumeration)
	        {
		        if (element < minValue)
	            {
		            minValue = element;
	            }
	        }   

            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
        {
            dynamic maxValue = int.MinValue;

            foreach (T element in enumeration)
	        {
		        if (element > maxValue)
	            {
		            maxValue = element;
	            }
	        }   
            return maxValue;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
        {
            dynamic average = (dynamic)(enumeration.Sum<T>()) / (dynamic)enumeration.Count<T>();
            return average;
        }

        public static T Count<T>(this IEnumerable<T> enumeration)
        {
            dynamic count = 0;

            foreach (T element in enumeration)
            {
                count++;
            }

            return count;
        }
    }
}
