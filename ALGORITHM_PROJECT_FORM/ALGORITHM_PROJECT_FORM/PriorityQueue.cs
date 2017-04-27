using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM_PROJECT_FORM
{

    public class PriorityQueue
    {
        private List<node> data;
        public Dictionary<string, int> search;

        public PriorityQueue()
        {
            this.data = new List<node>();
            search = new Dictionary<string, int>();
        }

        public void push(node item)
        {
            data.Add(item);
            if (!search.ContainsKey(item.unique))
                search.Add(item.unique, 0);
            search[item.unique]++;
            int ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                if (data[ci].unique == item.unique && item.steps < data[ci].steps)
                {
                    data.RemoveAt(ci);
                    search[item.unique]--;
                }
                int pi = (ci - 1) / 2; // parent index
                if (data[ci].final_heri.CompareTo(data[pi].final_heri) < 0)  // child item is larger than (or equal) parent so we're done
                {
                    node tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                }
                ci = pi;
            }
        }

        public node pop()
        {
            // assumes pq is not empty; up to calling code
            int li = data.Count - 1; // last index (before removal)
            node frontItem = data[0];// fetch the front
            search[data[0].unique]--;
            if (search[data[0].unique] == 0)
                search.Remove(data[0].unique);
            data[0] = data[li];
            data.RemoveAt(li);
            --li; // last index (after removal)
            int pi = 0; // parent index. start at front of pq
            while (true)
            {
                int ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break;  // no children so done
                int rc = ci + 1;     // right child
                if (rc <= li && data[rc].final_heri.CompareTo(data[ci].final_heri) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;
                if (data[pi].final_heri.CompareTo(data[ci].final_heri) <= 0) break; // parent is smaller than (or equal to) smallest child so done
                node tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }

        public node front()
        {
            node frontItem = data[0];
            return frontItem;
        }

        public int size()
        {
            return data.Count;
        }

        public bool IsConsistent()
        {
            // is the heap property true for all data?
            if (data.Count == 0) return true;
            int li = data.Count - 1; // last index
            for (int pi = 0; pi < data.Count; ++pi) // each parent index
            {
                int lci = 2 * pi + 1; // left child index
                int rci = 2 * pi + 2; // right child index

                if (lci <= li && data[pi].final_heri.CompareTo(data[lci].final_heri) > 0) return false; // if lc exists and it's greater than parent then bad.
                if (rci <= li && data[pi].final_heri.CompareTo(data[rci].final_heri) > 0) return false; // check the right child too.
            }
            return true; // passed all checks
        } // IsConsistent


    } // PriorityQueue

}
