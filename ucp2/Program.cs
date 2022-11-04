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
            Console.WriteLine("\n-------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                IP[1] = Int32.Parse(s1);
            } 
        }
        public void swap (int x, int y)
        {
            int temp;
            temp = IP[x];
            IP[x] = IP[y];
            IP[y] = temp;
        }
        //mergesort 
        void merge(int low, int mid, int high)
        {
            int i, RI, k;
            i = low;
            RI = mid + 1;
            k = low;
            while ((i <=mid) && (RI <=high))
            {
                if (IP[i] <= IP[RI])
                {
                    sorted[k++] = IP[i++]; 
                }
                else
                {
                    sorted[k++] = IP[RI++];
                }
            while (i<= mid )
            {
                    sorted[k++] = IP[i++]; 
             }
            while (RI <= high)
                {
                    sorted[k++] = IP[RI++]; 
                }
            for (i = low; i <= high; i++)
                {
                    IP[i] = sorted[i];
                }
            }
            //m_sort method 

        }
    }
}