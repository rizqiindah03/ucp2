using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        int[] IP = new int[87];
        int[] sorted = new int[87];
        int n;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 87))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 87 elements. \n ");
            }
        }

        
       
    }
}
