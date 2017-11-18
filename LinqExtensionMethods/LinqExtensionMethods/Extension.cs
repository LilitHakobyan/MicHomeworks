using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensionMethods
{
    public static class Extension
    {
        
        #region Aggregate
        //
        // Summary:
        //     Applies an accumulator function over a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to aggregate over.
        //
        //   func:
        //     An accumulator function to be invoked on each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The final accumulator value.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or func is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (func == null)
                throw new ArgumentNullException(nameof(func));
           
            using (IEnumerator<TSource> s=source.GetEnumerator())
            {
                if (!s.MoveNext())
                {
                    throw  new InvalidOperationException();
                }
                TSource result = s.Current;
                while (s.MoveNext())
                {
                    result = func(result, s.Current);
                }
                return result;
            }
        }


        #endregion

        #region All
        // Summary:
        //     Determines whether all elements of a sequence satisfy a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to apply
        //     the predicate to.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if every element of the source sequence passes the test in the specified
        //     predicate, or if the sequence is empty; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (TSource s in source)
            {
                if (!predicate(s))
                    return false;
            }
            return true;
        }
        #endregion
        #region Any
        // Summary:
        //     Determines whether a sequence contains any elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to check for emptiness.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains any elements; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (TSource s in source)
            {
                if (s != null)
                    return true;
            }
            return false;
        }
        // Summary:
        //     Determines whether any element of a sequence satisfies a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to apply the predicate
        //     to.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if any elements in the source sequence pass the test in the specified predicate;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach (TSource s in source)
            {
                if (predicate(s))
                    return true;
            }
            return false;
        }
        #endregion

        #region AsEnumerable

        // Summary:
        //     Returns the input typed as System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     The sequence to type as System.Collections.Generic.IEnumerable`1.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The input sequence typed as System.Collections.Generic.IEnumerable`1.
        public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
        {
            foreach (TSource s in source)
            {
                yield return s;
            }
        }

        #endregion

        #region Average
        // Summary:
        //     Computes the average of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Average(this IEnumerable<int> source)
        {
            if(source == null)
                throw new ArgumentNullException(nameof(source));
            int sum = 0;
            int count = 0;
            foreach (int s in source)
            {
                sum += s;
                count++;
            }
            return (double)sum / count;
        }
        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Single values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                return null;
            if (selector == null)
                return null;
            float count = 0;
            float? sum = 0;
            foreach (TSource s in source)
            {
                sum += selector(s);
                count++;
              
            }
            if (count != 0)
                return sum / count;
            throw new InvalidOperationException();
        }

        #endregion

        #region Cast
        //
        // Summary:
        //     Casts the elements of an System.Collections.IEnumerable to the specified type.
        //
        // Parameters:
        //   source:
        //     The System.Collections.IEnumerable that contains the elements to be cast to type
        //     TResult.
        //
        // Type parameters:
        //   TResult:
        //     The type to cast the elements of source to.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains each element of the
        //     source sequence cast to the specified type.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidCastException:
        //     An element in the sequence cannot be cast to type TResult.
        public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
        {
            if (source==null)
              throw new ArgumentNullException(nameof(source));
            return OfTypeIterator<TResult>(source);
        }

        public static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
        {
            foreach (var obj in source)
            {
                if (obj is TResult)
                {
                    yield return (TResult)obj;
                }
            }
        }
        #endregion

        #region Concat
        //
        // Summary:
        //     Concatenates two sequences.
        //
        // Parameters:
        //   first:
        //     The first sequence to concatenate.
        //
        //   second:
        //     The sequence to concatenate to the first sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of the input sequences.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the concatenated elements
        //     of the two input sequences.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     first or second is null.
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first==null)
            throw new ArgumentNullException(nameof(first));
            if (second==null)
            throw new ArgumentNullException(nameof(second));
            foreach (TSource firstSource in first)
                yield return firstSource;
            foreach (TSource secSource in second)
                yield return secSource;
        }
        #endregion

        #region Contains
        //
        // Summary:
        //     Determines whether a sequence contains a specified element by using the default
        //     equality comparer.
        //
        // Parameters:
        //   source:
        //     A sequence in which to locate a value.
        //
        //   value:
        //     The value to locate in the sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains an element that has the specified value;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
        {
            if (source==null)
            throw new ArgumentNullException(nameof(source));
            foreach (TSource itemSource in source)
            {
                if (value.Equals(itemSource))
                    return true;
            }
            return false;
        }
        //
        // Summary:
        //     Determines whether a sequence contains a specified element by using a specified
        //     System.Collections.Generic.IEqualityComparer`1.
        //
        // Parameters:
        //   source:
        //     A sequence in which to locate a value.
        //
        //   value:
        //     The value to locate in the sequence.
        //
        //   comparer:
        //     An equality comparer to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains an element that has the specified value;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach (TSource itemSource in source)
            {
                if (comparer.Equals(itemSource,value))
                    return true;
            }
            return false;
        }
        #endregion


    }

}

