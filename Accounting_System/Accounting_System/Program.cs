using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add_expense(5000);
        }

        static public void add_expense(int sum)
        {
            Console.WriteLine($"Добавлен расход: {sum}руб");
        }
    }
}
