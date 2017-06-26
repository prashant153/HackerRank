using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
                
        // Declare second integer, double, and String variables.
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        string s1;
        string all;
        // Read and save an integer, double, and String to your variables.
        s1=Console.ReadLine();
        all=s+s1;
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+a);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:0.0}", d+b));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(all);


