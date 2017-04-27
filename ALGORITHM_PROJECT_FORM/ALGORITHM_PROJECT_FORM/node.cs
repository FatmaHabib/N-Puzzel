using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM_PROJECT_FORM
{
    public class node
    {
        public int[,] arr;
        public int steps;
        public int final_heri;
        public int ham;
        public string unique;
        public int zero_place_x;
        public int zero_place_y;
        public List<node> children = new List<node>();


        public node(int dimention)
        {
            steps = 0;
            arr = new int[dimention, dimention];
            ham = 0;
            unique = "";
        }
        public node(int[,] puzzles, int dimetions)
        {

            arr = new int[dimetions, dimetions];
            for (int i = 0; i < dimetions; i++)
            {
                for (int j = 0; j < dimetions; j++)
                {
                    arr[i, j] = puzzles[i, j];
                    if (puzzles[i, j] == 0)
                    {
                        zero_place_x = i;
                        zero_place_y = j;
                    }
                }
            }
        }
    }
}
