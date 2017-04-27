using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ALGORITHM_PROJECT_FORM
{
    public class manhatten
    {
        int Manhatten;



        public manhatten()
        {

            Manhatten = 0;

        }
        public int Heuristics(int num, int[,] puzzle)
        {
            Manhatten = 0;
            for (int x = 0; x < num; x++)
            {
                for (int y = 0; y < num; y++)
                {
                    if (puzzle[x, y] == 0)
                        continue;
                    Manhatten += Math.Abs(x - (puzzle[x, y] - 1) / num) + Math.Abs(y - (puzzle[x, y] - 1) % num);
                }
            }
            return Manhatten;
        }

    }

}
