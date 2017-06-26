using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
           for(int i=0;i<n;i++)
           {
            string s=  Console.ReadLine();
            string[] words = s.Split(' ');
            int a=Convert.ToInt32(words[0]);
            int b=Convert.ToInt32(words[1]);
            int c=Convert.ToInt32(words[2]);
            int d=Convert.ToInt32(words[3]);
            
            Console.Write(2*c-a);
            Console.Write(" ");
            Console.Write(2*d-b);
            Console.WriteLine();
           }
    }
}