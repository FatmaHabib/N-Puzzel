using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ALGORITHM_PROJECT_FORM
{
    class solve
    {
        Dictionary<string, bool> visited;
        PriorityQueue open;
        Dictionary<node, node> cameFrom;
        hamming calculate;
        manhatten better;
        public int counter;
        int[] temp;
        string way;
        public List<node>total_path;

        public solve(int dim)
        {
            visited = new Dictionary<string, bool>();
            open = new PriorityQueue();
            cameFrom = new Dictionary<node, node>();
            calculate = new hamming(dim);
            better = new manhatten();
            way = "";
        }

        public string shape(int[,] arr, int length)
        {
            string convert = "";
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    convert += arr[i, j].ToString();
            return convert;
        }

        int getInvCount(int dimention)
        {

            int inv_count = 0;
            for (int i = 0; i < dimention * dimention - 1; i++)
                for (int j = i + 1; j < dimention * dimention; j++)
                    // Value 0 is used for empty space
                    if (temp[j] != 0 && temp[i] != 0 && temp[i] > temp[j])
                        inv_count++;
            return inv_count;
        }

        // This function returns true if given 8 puzzle is solvable.
        public bool isSolvable(int[,] puzzle, int solve_dimention)
        {
            temp = new int[solve_dimention * solve_dimention + 1];
            int zero_palce = 0;
            // Count inversions in given puzzle
            for (int i = 0; i < solve_dimention; i++)
            {
                for (int j = 0; j < solve_dimention; j++)
                {
                    temp[solve_dimention * i + j] = puzzle[i, j];
                    if (puzzle[i, j] == 0)
                        zero_palce = i + 1;
                }
            }
            int invCount = getInvCount(solve_dimention);

            // return true if inversion count is even.
            if ((invCount % 2 == 0 && solve_dimention % 2 != 0) || (zero_palce % 2 == invCount % 2 && solve_dimention % 2 == 0))
                return true;
            else
                return false;
        }

        public void display(Dictionary<node, node> matrix, node current, int display_dimention)
        {

            total_path = new List<node>();
            counter = 0;
            total_path.Add(current);
            while (matrix.Keys.Contains(current) && current != cameFrom[current])
            {
                current = cameFrom[current];
                total_path.Add(current);
            }
        }

        #region solving puzzle using A*

        public void solve_prob(node start, node goal, int dimention,char way)
        {
            cameFrom[start] = start;
            start.steps = 0;
            if (way == 'h' || way == 'H')
                start.ham = calculate.hamming_method(start.arr, dimention);
            else
                start.ham = better.Heuristics(dimention, start.arr);
            start.final_heri = start.steps + start.ham;
            start.unique = shape(start.arr, dimention);
            open.push(start);
            while (open.size() != 0)
            {
                node x = open.pop();
                visited.Add(x.unique, true);
                #region its the goal
                if (x.ham == 0)
                {
                    cameFrom[goal] = x;
                  display(cameFrom, goal, dimention);
                    break;
                }
                #endregion

                # region if it's not the goal
                generate_children(x, dimention,way);
                #region farther move
                for (int i = 0; i < x.children.Count; i++)
                {
                    int newcost = x.steps + (Math.Abs(x.steps - x.children[i].steps));
                    if (!visited.ContainsKey(x.children[i].unique) || newcost < x.children[i].steps)
                    {

                        if (!open.search.ContainsKey(x.children[i].unique) || newcost < x.children[i].steps)
                        {
                            x.children[i].steps = newcost;
                            x.children[i].final_heri = x.children[i].steps + x.children[i].ham;
                            open.push(x.children[i]);
                        }
                        cameFrom[x.children[i]] = x;
                    }
                }

            }
                #endregion
                #endregion
        }// end of while (open not empty)
        private void generate_children(node parent, int dimention_child,char way)
        {
            int var = 0;
            node test_node;
            #region up 
            if (parent.zero_place_x > 0)
            {
                test_node = new node(parent.arr, dimention_child);
                var = test_node.arr[parent.zero_place_x, parent.zero_place_y];
                test_node.arr[parent.zero_place_x, parent.zero_place_y] = test_node.arr[parent.zero_place_x - 1, parent.zero_place_y];
                test_node.arr[parent.zero_place_x - 1, parent.zero_place_y] = var;
                if (way == 'H' || way == 'h')
                    test_node.ham = calculate.hamming_method(test_node.arr, dimention_child);
                else
                    test_node.ham = better.Heuristics(dimention_child, test_node.arr);
                test_node.steps = parent.steps + 1;
                test_node.final_heri = test_node.steps + test_node.ham;
                test_node.unique = shape(test_node.arr, dimention_child);
                test_node.zero_place_x = parent.zero_place_x - 1;
                test_node.zero_place_y = parent.zero_place_y;
                parent.children.Add(test_node);
            }

            #endregion

            #region down
            if (parent.zero_place_x + 1 < dimention_child)
            {
                test_node = new node(parent.arr, dimention_child);
                var = test_node.arr[parent.zero_place_x, parent.zero_place_y];
                test_node.arr[parent.zero_place_x, parent.zero_place_y] = test_node.arr[parent.zero_place_x + 1, parent.zero_place_y];
                test_node.arr[parent.zero_place_x + 1, parent.zero_place_y] = var;
                if (way == 'H' || way== 'h')
                    test_node.ham = calculate.hamming_method(test_node.arr, dimention_child);
                else
                    test_node.ham = better.Heuristics(dimention_child, test_node.arr);
                test_node.steps = parent.steps + 1;
                test_node.final_heri = test_node.steps + test_node.ham;
                test_node.unique = shape(test_node.arr, dimention_child);
                test_node.zero_place_x = parent.zero_place_x + 1;
                test_node.zero_place_y = parent.zero_place_y;
                parent.children.Add(test_node);

            }
            #endregion

            #region left
            if (parent.zero_place_y > 0)
            {
                test_node = new node(parent.arr, dimention_child);
                var = test_node.arr[parent.zero_place_x, parent.zero_place_y];
                test_node.arr[parent.zero_place_x, parent.zero_place_y] = test_node.arr[parent.zero_place_x, parent.zero_place_y - 1];
                test_node.arr[parent.zero_place_x, parent.zero_place_y - 1] = var;
                if (way == 'H' || way == 'h')
                    test_node.ham = calculate.hamming_method(test_node.arr, dimention_child);
                else
                    test_node.ham = better.Heuristics(dimention_child, test_node.arr);
                test_node.steps = parent.steps + 1;
                test_node.final_heri = test_node.steps + test_node.ham;
                test_node.unique = shape(test_node.arr, dimention_child);
                test_node.zero_place_x = parent.zero_place_x;
                test_node.zero_place_y = parent.zero_place_y - 1;
                parent.children.Add(test_node);


            }
            #endregion

            #region right
            if (parent.zero_place_y + 1 < dimention_child)
            {
                test_node = new node(parent.arr, dimention_child);
                var = test_node.arr[parent.zero_place_x, parent.zero_place_y];
                test_node.arr[parent.zero_place_x, parent.zero_place_y] = test_node.arr[parent.zero_place_x, parent.zero_place_y + 1];
                test_node.arr[parent.zero_place_x, parent.zero_place_y + 1] = var;
                if (way == 'H' || way == 'h')
                    test_node.ham = calculate.hamming_method(test_node.arr, dimention_child);
                else
                    test_node.ham = better.Heuristics(dimention_child, test_node.arr);
                test_node.steps = parent.steps + 1;
                test_node.final_heri = test_node.steps + test_node.ham;
                test_node.unique = shape(test_node.arr, dimention_child);
                test_node.zero_place_x = parent.zero_place_x;
                test_node.zero_place_y = parent.zero_place_y + 1;
                parent.children.Add(test_node);

            }
            #endregion 
        } // end of  function
    } // end of solve problem function
        #endregion
} // end of class
