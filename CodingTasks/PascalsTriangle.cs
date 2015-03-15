using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    public class PascalsTriangle
    {
        public List<List<int>> Generate(int numRows)
        {
            if (numRows == 0)
            {
                Console.WriteLine("[]");
                return new List<List<int>>();
            }
            List<int> row1 = new List<int>();
            row1.Add(1);
            List<List<int>> setOfRows = new List<List<int>>();

            if (numRows == 1)
            {
                setOfRows.Add(row1);
                Console.WriteLine("[1]");
                return setOfRows;
            }

            for (int i = 0; i < numRows - 1; i++)
            {
                List<int> row = new List<int>();
                row.Add(1);

                for (int j = 0; j < i; j++)
                {
                    List<int> prevList = setOfRows[i - 1];
                    int tmp = prevList[j] + prevList[j + 1];
                    row.Add(tmp);
                }
                row.Add(1);
                setOfRows.Add(row);
            }
            setOfRows.Insert(0, row1);
            PrintResult(setOfRows);
            return setOfRows;
        }

        private void PrintResult(List<List<int>> listlist)
        {
            int l = listlist.Count;
            Console.WriteLine("[");

            for (int o = 0; o < l; o++ )
            {
                for (int i = 0; i < l - o; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("[");
                int k = listlist[o].Count;

                for (int m = 0; m < k - 1; m++)
                {
                    Console.Write(listlist[o][m] + ",");
                }
                Console.Write(listlist[o][k-1]);
                if (o == l - 1)
                {
                    Console.Write("]\n");
                }
                else
                {
                    Console.Write("],\n");
                }
                
            }
            Console.WriteLine("]");
        }
    }
}
