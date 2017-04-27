using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM_PROJECT_FORM
{
    public class hamming
    {
        public node goal;
        public int counter;
        int h;
        public hamming(int dimention_hammi)
        {
            goal = new node(dimention_hammi);
            int count = 1;
            for (int i = 0; i < dimention_hammi; i++)
            {
                for (int j = 0; j < dimention_hammi; j++)
                {
                    goal.arr[i, j] = count;
                    count++;

                }
            }
            goal.arr[dimention_hammi - 1, dimention_hammi - 1] = 0;
        }

        public int hamming_method(int[,] arr, int dimention_method)
        {
            h = 0;
            for (int i = 0; i < dimention_method; i++)
            {
                for (int k = 0; k < dimention_method; k++)
                {
                    if (arr[i, k] != goal.arr[i, k] && arr[i, k] != 0)
                        h++;
                }
            }
            return h;
        }
    }
}
