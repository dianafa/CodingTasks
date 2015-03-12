using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    public class PascalsTriangle
    {
        /*public IList<IList<int>> Generate(int numRows)
        {
         
        }*/

        public List<List<int>> Generate(int numRows)
        {
            List<int> row = new List<int>();
            List<List<int>> setOfRows = new List<List<int>>();
            row.Add(1);
            row.Add(5);
            setOfRows.Add(row);
            return setOfRows;
        }

        void PrintResult(List<List<int>> listlist)
        {
            ;
        }
    }
}
