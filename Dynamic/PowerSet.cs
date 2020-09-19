using System.Collections.Generic;

namespace Dynamic
{
    /*
     * Power Set: Write a method to return all subsets of a set.
     * Tip: How to generate subsets of {a, b, c} from subsets of {a, b}
     */
    public class PowerSet<T>
    {
        public static List<HashSet<T>> PowerSetAlgo(HashSet<T> set)
        {
            var subsets = new List<HashSet<T>>();
            if(set.Count == 0)
            {
                subsets.Add(new HashSet<T>());
                return subsets;
            }

            var enumerator = set.GetEnumerator();
            enumerator.MoveNext();
            var removedElement = enumerator.Current;
            set.Remove(removedElement);
            var subsetsOfOneElementRemoved = PowerSetAlgo(set);
            foreach(var subset in subsetsOfOneElementRemoved)
            {
                subsets.Add(subset);
                var newSubset = new HashSet<T>(subset);
                newSubset.Add(removedElement);
                subsets.Add(newSubset);
            }
            return subsets;
        }
    }
}
