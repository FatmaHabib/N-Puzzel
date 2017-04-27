using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ALGORITHM_PROJECT_FORM
{
    public class input
    {
        public int width;
        public char method;
        public string inp;
        public string[] cols;
        public int[,] puzzle;
        public int tc_3 = 0, tc_4 = 0,tc_5=0,tc_10=0;
        public hamming answer;
        public List<node> Final_answer;
        public void ReadData(int N,char methode)
        {
            this.method = methode;
           if (N==3)
           {
                if (tc_3 == 0)
                    Read_Case("8 Puzzle Sample.txt");
                else if (tc_3 == 1)
                    Read_Case("8 Puzzle Board 1.txt");

                else if (tc_3 == 2)
                    Read_Case("8 Puzzle Board 2.txt");
                else if (tc_3 == 3)
                    Read_Case("8 Puzzle Board 3 - Unsolvable.txt");
                else if (tc_3 == 4)
                    Read_Case("8 Puzzle (1).txt");
                else if (tc_3 == 5)
                    Read_Case("8 Puzzle (2).txt");
                else if (tc_3 == 6)
                    Read_Case("8 Puzzle (3).txt");
                else if (tc_3 == 7)
                    Read_Case("8 Puzzle - Case 1.txt");
                else if (tc_3 == 8)
                    Read_Case("8 Puzzle(2) - Case 1.txt");
                else if (tc_3 == 9)
                    Read_Case("8 Puzzle(3) - Case 1.txt");
               tc_3++;
           }
           else if (N==4)
           {
                 if (tc_4 == 0)
                    Read_Case("15 Puzzle Board.txt");
                else if (tc_4 == 1)
                    Read_Case("15 Puzzle Board 2 - Unsolvable.txt");
                else if (tc_4 == 11)
                     Read_Case("15 Puzzle Board 1.txt");
                 else if (tc_4 == 3)
                     Read_Case("15 Puzzle 1.txt");
                 else if (tc_4 == 4)
                     Read_Case("15 Puzzle 3.txt");
                 else if (tc_4 == 5)
                     Read_Case("15 Puzzle 4.txt");
                 else if (tc_4 == 6)
                     Read_Case("15 Puzzle 1 - Unsolvable.txt");
                 else if (tc_4 == 7)
                     Read_Case("15 Puzzle - 1.txt");
                 else if (tc_4 == 8)
                     Read_Case("15 Puzzle - Case 2.txt");
                 else if (tc_4 == 9)
                     Read_Case("15 Puzzle - Case 3.txt");
                else if (tc_4 == 10)
                    Read_Case("15 Puzzle 5.txt");
                else if (tc_4 == 2)
                    Read_Case("TEST_long_move.txt");

                tc_4++;
           }
           else if (N == 5)
           {
               if (tc_5 == 0)
                   Read_Case("24 Puzzle 1.txt");
               else if (tc_5== 1)
                   Read_Case("24 Puzzle 2.txt");
               tc_5++;
           }
           else if (N == 10)
           {
               if (tc_10 == 0)
                   Read_Case("99 Puzzle - 1.txt");
               else if (tc_10 == 1)
                   Read_Case("99 Puzzle - 2.txt");
               else if (tc_10 == 2)
                   Read_Case("99 Puzzle - Unsolvable Case 1.txt");
               else if (tc_10 == 3)
                   Read_Case("99 Puzzle - Unsolvable Case 2.txt");
               tc_10++;
           }
           
        }
        public bool solve_Npuzzle()
        {
            solve solve_puzzle = new solve(width);
            Final_answer = new List<node>();
            answer = new hamming(width);
            node puzzle_node = new node(puzzle, width);
            if (solve_puzzle.isSolvable(puzzle, width))
            {
                solve_puzzle.solve_prob(puzzle_node, answer.goal, width, method);
                Console.WriteLine();
                this.Final_answer = solve_puzzle.total_path;
            }
            else return false;
            return true;
           
        }
        public void Read_Case(string fil)
        {
            FileStream FS = new FileStream(fil, FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            inp = SR.ReadLine();
            width = int.Parse(inp);
            puzzle = new int[width, width];


            for (int i = 0; i < width; i++)
            {
                inp = SR.ReadLine();
                cols = inp.Split(' ');
                for (int j = 0; j < width; j++)
                    puzzle[i, j] = int.Parse(cols[j]);
            }
            SR.Close();
            FS.Close();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(puzzle[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
