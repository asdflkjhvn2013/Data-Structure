using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            ListByArray listByArray = new ListByArray(10);
            listByArray.Append(10);
            listByArray.Append(15);
            listByArray.Append(14);
            listByArray.Append(11);
            listByArray.Append(19);
            listByArray.PrintList();
            listByArray.Remove(11);
            listByArray.PrintList();
        }
    }
}
