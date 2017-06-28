//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            int N = arr[0];
            int[] S = new int[]{0,0,0};
            int Q = arr[1];
            int lastAnswer = 0;
            List<int>[] list=new List<int>[100];
            for(int i=0;i<N;i++)
            {
                list[i] = new List<int>();
            }
            for(int i=0;i<Q;i++)
            {
                string[] qry_temp = Console.ReadLine().Split(' ');
                int[] qry = Array.ConvertAll(qry_temp,Int32.Parse);
                if(qry[0]==1)
                {
                    list[(qry[1] ^ lastAnswer)%N]=list[(qry[1] ^ lastAnswer)%N].Add(qry[2]);
                }
                else
                {
                    lastAnswer = qry[2]%(list[(qry[1] ^ lastAnswer)%N].Count);
                    Console.WriteLine(lastAnswer);
                }
                                
            }
            
           
        }
    }
}
