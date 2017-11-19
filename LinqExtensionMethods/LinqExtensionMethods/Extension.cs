using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            using (IEnumerator<TSource> s = source.GetEnumerator())
            {
                if (!s.MoveNext())
                {
                    throw new InvalidOperationException();
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
            if (source == null)
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
            if (source == null)
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
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
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
            if (source == null)
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
                if (comparer.Equals(itemSource, value))
                    return true;
            }
            return false;
        }
        #endregion

        #region Count
        //
        // Summary:
        //     Returns a number that represents how many elements in the specified sequence
        //     satisfy a condition.
        //
        // Parameters:
        //   source:
        //     A sequence that contains elements to be tested and counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A number that represents how many elements in the sequence satisfy the condition
        //     in the predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            int count = 0;
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            foreach (TSource itemSource in source)
            {
                if (predicate(itemSource))
                {
                    checked
                    {
                        count++;
                    }
                }

            }
            return count;
        }
        //
        // Summary:
        //     Returns the number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     A sequence that contains elements to be counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The number of elements in the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this IEnumerable<TSource> source)
        {

            int count = 0;
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (TSource itemSource in source)
            {
                checked
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region DefaultIfEmpty
        //
        // Summary:
        //     Returns the elements of the specified sequence or the type parameter's default
        //     value in a singleton collection if the sequence is empty.
        //
        // Parameters:
        //   source:
        //     The sequence to return a default value for if it is empty.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 object that contains the default
        //     value for the TSource type if source is empty; otherwise, source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentException(nameof(source));
            return source.DefaultIfEmpty(default(TSource));
        }

        //
        // Summary:
        //     Returns the elements of the specified sequence or the specified value in a singleton
        //     collection if the sequence is empty.
        //
        // Parameters:
        //   source:
        //     The sequence to return the specified value for if it is empty.
        //
        //   defaultValue:
        //     The value to return if the sequence is empty.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains defaultValue if source
        //     is empty; otherwise, source.
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source,
            TSource defaultValue)
        {
            foreach (TSource sitem in source)
            {
                if (sitem == null)
                {
                    yield return defaultValue;
                }
                else
                {
                    yield return sitem;
                }
            }
        }

        #endregion

        #region Distinct
        //
        // Summary:
        //     Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        //     to compare values.
        //
        // Parameters:
        //   source:
        //     The sequence to remove duplicate elements from.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains distinct elements from
        //     the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.

        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return DistinctIterator<TSource>(source, null);
        }
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source,
            IEqualityComparer<TSource> comparer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return DistinctIterator<TSource>(source, comparer);
        }

        private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);
            foreach (TSource source1 in source)
            {
                if (set.Add(source1))
                    yield return source1;
            }
        }
        #endregion

        #region ElementAt
        //
        // Summary:
        //     Returns the element at a specified index in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   index:
        //     The zero-based index of the element to retrieve.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The element at the specified position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than 0 or greater than or equal to the number of elements in source.
        public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            IList<TSource> sourceList = source as IList<TSource>;
            if (sourceList != null)
                return sourceList[index];
            foreach (TSource sItem in source)
            {
                if (index == 0)
                    return sItem;
                --index;
            }
            throw new ArgumentOutOfRangeException(nameof(index));

        }


        #endregion

        #region ElementAtOrDefault
        //
        // Summary:
        //     Returns the element at a specified index in a sequence or a default value if
        //     the index is out of range.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   index:
        //     The zero-based index of the element to retrieve.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        //     the element at the specified position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (index >= 0)
            {
                IList<TSource> sourceList = source as IList<TSource>;
                if (sourceList != null)
                {
                    if (index < sourceList.Count)
                        return sourceList[index];
                }
                else
                {
                    foreach (TSource source1 in source)
                    {
                        if (index == 0)
                            return source1;
                        --index;
                    }
                }
            }
            return default(TSource);
        }


        #endregion

        #region Empty
        //
        // Summary:
        //     Returns an empty System.Collections.Generic.IEnumerable`1 that has the specified
        //     type argument.
        //
        // Type parameters:
        //   TResult:
        //     The type to assign to the type parameter of the returned generic System.Collections.Generic.IEnumerable`1.
        //
        // Returns:
        //     An empty System.Collections.Generic.IEnumerable`1 whose type argument is TResult.
        public static IEnumerable<TResult> Empty<TResult>()
        {
            return new TResult[0];
        }


        #endregion

        #region Except
        //
        // Summary:
        //     Produces the set difference of two sequences by using the default equality comparer
        //     to compare values.
        //
        // Parameters:
        //   first:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that are not also
        //     in second will be returned.
        //
        //   second:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that also occur in
        //     the first sequence will cause those elements to be removed from the returned
        //     sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of the input sequences.
        //
        // Returns:
        //     A sequence that contains the set difference of the elements of two sequences.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     first or second is null.
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));
            return ExceptIterator<TSource>(first, second, (IEqualityComparer<TSource>)null);
        }
        //
        // Summary:
        //     Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        //     to compare values.
        //
        // Parameters:
        //   first:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that are not also
        //     in second will be returned.
        //
        //   second:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that also occur in
        //     the first sequence will cause those elements to be removed from the returned
        //     sequence.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of the input sequences.
        //
        // Returns:
        //     A sequence that contains the set difference of the elements of two sequences.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     first or second is null.
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)

        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));
            return ExceptIterator<TSource>(first, second, comparer);
        }
        private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);

            foreach (TSource source in second)
                set.Add(source);
            foreach (TSource source in first)
            {
                if (set.Add(source))
                    yield return source;
            }
        }
        #endregion

        #region First
        //
        // Summary:
        //     Returns the first element in a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate.-or-The source sequence is empty.
        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(source));
            foreach (TSource sitem in source)
            {
                if (predicate(sitem))
                    return sitem;
            }
            throw new InvalidOperationException();
        }
        //
        // Summary:
        //     Returns the first element of a sequence.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the specified sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {

            if (source == null)
                throw new ArgumentNullException(nameof(source));
            IList<TSource> sourceList = source as IList<TSource>;
            if (sourceList != null)
            {
                if (sourceList.Count > 0)
                    return sourceList[0];
            }
            foreach (TSource item in source)
            {
                return item;
            }
            throw new InvalidOperationException();
        }



        #endregion

        #region FirstOrDefault

        //
        // Summary:
        //     Returns the first element of the sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty or if no element passes the test specified
        //     by predicate; otherwise, the first element in source that passes the test specified
        //     by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(source));
            foreach (TSource sitem in source)
            {
                if (predicate(sitem))
                    return sitem;
            }
            return default(TSource);
        }
        //
        // Summary:
        //     Returns the first element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty; otherwise, the first element in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            IList<TSource> sourceList = source as IList<TSource>;
            if (sourceList != null)
            {
                if (sourceList.Count > 0)
                    return sourceList[0];
            }
            foreach (TSource item in source)
            {
                return item;
            }
            return default(TSource);
        }

        #endregion

        #region Intersect
        //
        // Summary:
        //     Produces the set difference of two sequences by using the default equality comparer
        //     to compare values.
        //
        // Parameters:
        //   first:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that are not also
        //     in second will be returned.
        //
        //   second:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that also occur in
        //     the first sequence will cause those elements to be removed from the returned
        //     sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of the input sequences.
        //
        // Returns:
        //     A sequence that contains the set difference of the elements of two sequences.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     first or second is null.
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));
            return IntersectIterator<TSource>(first, second, (IEqualityComparer<TSource>)null);
        }
        //
        // Summary:
        //     Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        //     to compare values.
        //
        // Parameters:
        //   first:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that are not also
        //     in second will be returned.
        //
        //   second:
        //     An System.Collections.Generic.IEnumerable`1 whose elements that also occur in
        //     the first sequence will cause those elements to be removed from the returned
        //     sequence.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of the input sequences.
        //
        // Returns:
        //     A sequence that contains the set difference of the elements of two sequences.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     first or second is null.
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)

        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));
            return ExceptIterator<TSource>(first, second, comparer);
        }
        private static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);

            foreach (TSource source in second)
                set.Add(source);
            foreach (TSource source in first)
            {
                if (set.Remove(source))
                    yield return source;
            }
        }
        #endregion

        #region  Last and LastOrDefault 
        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The last element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate.-or-The source sequence is empty.
        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            TSource source1 = default(TSource);
            bool flag = false;
            foreach (TSource sourceItem in source)
            {
                if (predicate(sourceItem))
                {
                    source1 = sourceItem;
                    flag = true;
                }
            }
            if (flag)
                return source1;
            throw new InvalidOperationException("No mach");
        }
        //
        // Summary:
        //     Returns the last element of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value at the last position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource Last<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            TSource source1 = default(TSource);
            int count1 = 0;
            IList<TSource> sourceList = source as IList<TSource>;
            if (sourceList != null)
            {
                int count = sourceList.Count;
                if (count > 0)
                    return sourceList[count - 1];
            }
            foreach (TSource sourceItem in source)
            {
                source1 = sourceItem;
                count1++;

            }
            if (count1 != 0)
                return source1;
            throw new InvalidOperationException("No mach");
        }
        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the sequence is empty or if no elements pass the test in
        //     the predicate function; otherwise, the last element that passes the test in the
        //     predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {

            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            TSource source1 = default(TSource);
            bool flag = false;
            foreach (TSource sourceItem in source)
            {
                if (predicate(sourceItem))
                {
                    source1 = sourceItem;
                    flag = true;
                }
            }
            if (flag)
                return source1;
            return default(TSource);
        }
        //
        // Summary:
        //     Returns the last element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the source sequence is empty; otherwise, the last element
        //     in the System.Collections.Generic.IEnumerable`1.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            TSource source1 = default(TSource);
            int count1 = 0;
            IList<TSource> sourceList = source as IList<TSource>;
            if (sourceList != null)
            {
                int count = sourceList.Count;
                if (count > 0)
                    return sourceList[count - 1];
            }
            foreach (TSource sourceItem in source)
            {
                source1 = sourceItem;
                count1++;

            }
            if (count1 != 0)
                return source1;
            return default(TSource);
        }


        #endregion

        #region LongCount
        //
        // Summary:
        //     Returns an System.Int64 that represents how many elements in a sequence satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to be
        //     counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A number that represents how many elements in the sequence satisfy the condition
        //     in the predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.OverflowException:
        //     The number of matching elements exceeds System.Int64.MaxValue.
        public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            long count = 0;
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            foreach (TSource itemSource in source)
            {
                if (predicate(itemSource))
                {
                    checked
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //
        // Summary:
        //     Returns an System.Int64 that represents the total number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to be
        //     counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The number of elements in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The number of elements exceeds System.Int64.MaxValue.
        public static long LongCount<TSource>(this IEnumerable<TSource> source)
        {
            long count = 0;
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach (TSource itemSource in source)
            {
                checked
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region Max
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Double value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static TSource Max<TSource>(this IEnumerable<TSource> source)
        {
            long count = 0;
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            Comparer<TSource> comparer = Comparer<TSource>.Default;
            TSource max = default(TSource);
            bool flag = false;
            foreach (TSource item in source)
            {
                if (flag)
                {
                    if (comparer.Compare(max,item) > 0)
                        max = item;
                }
                else
                {
                    max = item;
                    flag = true;
                }
            }
            if (flag)
                return max;
            throw new InvalidOperationException("No mach");
        }

        #endregion

        #region Range

        //
        // Summary:
        //     Generates a sequence of integral numbers within a specified range.
        //
        // Parameters:
        //   start:
        //     The value of the first integer in the sequence.
        //
        //   count:
        //     The number of sequential integers to generate.
        //
        // Returns:
        //     An IEnumerable<Int32> in C# or IEnumerable(Of Int32) in Visual Basic that contains
        //     a range of sequential integral numbers.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     count is less than 0.-or-start + count -1 is larger than System.Int32.MaxValue.
        public static IEnumerable<int> Range(int start, int count)
        {
            if(count<0||(long)start + count + -1 > Int32.MaxValue)
                for (int i = 0; i < count; i++)
                {
                    yield return start + 1;
                }
        }
        #endregion

        #region Repeat
        //
        // Summary:
        //     Generates a sequence that contains one repeated value.
        //
        // Parameters:
        //   element:
        //     The value to be repeated.
        //
        //   count:
        //     The number of times to repeat the value in the generated sequence.
        //
        // Type parameters:
        //   TResult:
        //     The type of the value to be repeated in the result sequence.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains a repeated value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     count is less than 0.
        public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
        {
            if (count<0)
                throw new ArgumentNullException(nameof(count));
            for (int i = 0; i < count; i++)
                yield return element;
        }
        #endregion

        #region OfType
        //
        // Summary:
        //     Filters the elements of an System.Collections.IEnumerable based on a specified
        //     type.
        //
        // Parameters:
        //   source:
        //     The System.Collections.IEnumerable whose elements to filter.
        //
        // Type parameters:
        //   TResult:
        //     The type to filter the elements of the sequence on.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains elements from the input
        //     sequence of type TResult.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
        {
            if(source==null)
                throw new ArgumentNullException(nameof(source));
            foreach (var item in source)
            {
                if (item.GetType() == typeof(TResult))//item is TResult
                    yield return (TResult)item;
            }
        }
        #endregion

        #region Single
        //
        // Summary:
        //     Returns the only element of a sequence that satisfies a specified condition,
        //     and throws an exception if more than one such element exists.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return a single element from.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence that satisfies a condition.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate.-or-More than one element satisfies
        //     the condition in predicate.-or-The source sequence is empty.
        public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            TSource result = default(TSource);
            long count = 0;
            foreach (TSource itemSource in source)
            {
                if (predicate(itemSource))
                {
                    checked
                    {
                        ++count;
                    }
                    result = itemSource;
                }
            }
            if (count == 0)
                throw new InvalidOperationException("No Elements");
            if (count == 1)
                return result;
            throw new InvalidOperationException("More Than One Match");
        }
        //
        // Summary:
        //     Returns the only element of a sequence, and throws an exception if there is not
        //     exactly one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The input sequence contains more than one element.-or-The input sequence is empty.
        public static TSource Single<TSource>(this IEnumerable<TSource> source)
        {

            if (source == null)
                throw new ArgumentNullException(nameof(source));
            TSource result = default(TSource);
            long count = 0;
            foreach (TSource itemSource in source)
            {
                  checked
                    {
                        ++count;
                    }
                    result = itemSource;
            }
            if (count == 0)
                throw new InvalidOperationException("No Elements");
            if (count == 1)
                return result;
            throw new InvalidOperationException("More Than One Match");
        }
        #endregion

        #region Skip
        //
        // Summary:
        //     Bypasses a specified number of elements in a sequence and then returns the remaining
        //     elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return elements from.
        //
        //   count:
        //     The number of elements to skip before returning the remaining elements.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements that occur
        //     after the specified index in the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
        {
           if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach (TSource item in source)
            {
                --count;
                if (count <= 0)
                    yield return item;
            }

        }
        //
        // Summary:
        //     Bypasses elements in a sequence as long as a specified condition is true and
        //     then returns the remaining elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return elements from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements from the
        //     input sequence starting at the first element in the linear series that does not
        //     pass the test specified by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            bool res = false;
            foreach (TSource item in source)
            {
                if (!res && predicate(item))
                    res = true;
                if (res)
                    yield return item;
            }
        }
        #endregion

        #region ToDictionary
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to specified key selector and element selector functions.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        //     selected from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.-or-keySelector produces a key
        //     that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (keySelector == null)
                throw new ArgumentNullException(nameof(keySelector));
            if (elementSelector == null)
                throw new ArgumentNullException(nameof(elementSelector));
            Dictionary<TKey, TElement> dic=new Dictionary<TKey, TElement>(comparer);
            foreach (TSource itemSource in source)
            dic.Add(keySelector(itemSource),elementSelector(itemSource));
            return dic;
        }
        #endregion
    }

}

