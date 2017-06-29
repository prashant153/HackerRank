using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp,long.Parse);
            long N = arr[0];
            long Q = arr[1];
            long lastAnswer = 0;
            List<long>[] list=new List<long>[N];
            for(int i=0;i<N;i++)
            {
                list[i] = new List<long>();
            }
            for(int i=0;i<Q;i++)
            {
                string[] qry_temp = Console.ReadLine().Split(' ');
                int[] qry = Array.ConvertAll(qry_temp,Int32.Parse);
                if(qry[0]==1)
                {
                    list[(qry[1] ^ lastAnswer)%N].Add(qry[2]);
                }
                else
                {
                    //lastAnswer = qry[2]%(list[(qry[1] ^ lastAnswer)%N].Count);
                    lastAnswer =  list[(qry[1] ^ lastAnswer)%N][qry[2]%(list[(qry[1] ^ lastAnswer)%N].Count)];
                    Console.WriteLine(lastAnswer);
                }
                                
            }
            
    }
}
