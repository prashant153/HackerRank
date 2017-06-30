using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            int n = arr[0];
            int d = arr[1];
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            if (n == d)
            {
                foreach (int value in a)
                {
                    Console.Write(value);
                    Console.Write(" ");
                }
            }
            else
            {
                int[] b = new int[d];
                int[] c = new int[n - d];
                Array.Copy(a, 0, b, 0, d);
                Array.Copy(a, d, c, 0, n-d);
                Array.Copy(c, 0, a, 0, n - d);
                Array.Copy(b, 0, a, n - d, d);

                foreach (int value in a)
                {
                    Console.Write(value);
                    Console.Write(" ");
                }
                Console.ReadKey();
            }
        }
    }
}
