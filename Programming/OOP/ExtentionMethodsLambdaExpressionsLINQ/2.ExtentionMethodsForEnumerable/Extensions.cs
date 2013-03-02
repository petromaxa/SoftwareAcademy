using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ExtentionMethodsForEnumerable
{
    static class Extensions
    {
        // Sum method
        public static decimal Sum<T>(this IEnumerable<T> enumeration)
            where T: struct, IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the sum of an empty enumeration!");
            }
            decimal sum = 0;
            try
            {
                foreach (var element in enumeration)
                {
                    sum = sum + Convert.ToDecimal(element);
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("The sum is bigger than Maximal Decimal number!");
            }
            catch (FormatException)
            {
                throw new FormatException("The element cannot be converted to Decimal number!");
            }
            return sum;
        }

        //Product method
        public static decimal Product<T>(this IEnumerable<T> enumeration)
            where T : struct, IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the product of an empty enumeration!");
            }
            decimal product = 1;
            try
            {
                foreach (var element in enumeration)
                {
                    product = product * Convert.ToDecimal(element);
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("The product is bigger than Maximal Decimal number!");
            }
            return product;
        }

        // Min method
        public static decimal Min<T>(this IEnumerable<T> enumeration)
            where T : struct, IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the Minimal element of an empty enumeration!");
            }
            decimal minimal = Decimal.MaxValue;
            try
            {
                foreach (var element in enumeration)
                {
                    if (minimal > Convert.ToDecimal(element))
                    {
                        minimal = Convert.ToDecimal(element);
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("The element cannot be converted to Decimal number!");
            }
            return minimal;
        }

        // Max method
        public static decimal Max<T>(this IEnumerable<T> enumeration)
            where T : struct, IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the Minimal element of an empty enumeration!");
            }
            decimal maximal = Decimal.MinValue;
            try
            {
                foreach (var element in enumeration)
                {
                    if (maximal < Convert.ToDecimal(element))
                    {
                        maximal = Convert.ToDecimal(element);
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("The element cannot be converted to Decimal number!");
            }
            return maximal;
        }


        // Average method
        public static decimal Average<T>(this IEnumerable<T> enumeration)
            where T : struct, IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the Average of an empty enumeration!");
            }
            decimal average = enumeration.Sum()/enumeration.ToList().Count;
            return average;
        }
    }
}
