using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int>  dictionary= new Dictionary<string, int>();
            
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if(dictionary.ContainsKey(s))
                    dictionary[s]++;
                else dictionary.Add(s, 1);
            }
            int m = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                string t = Console.ReadLine();
                if (dictionary.ContainsKey(t))
                Console.WriteLine(dictionary[t]);
                else 
                    Console.WriteLine(0);
            }
    }
}