using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<int> a = new List<int>(5);
        string s = Console.ReadLine();
        string[] input = s.Split(new char[] {' '});
        if (input.Length < 5)
            return;
        for (int i = 0; i < 5; i++){
            a.Add(Convert.ToInt32(input[i]));
        };
        
        int min = int.MaxValue, max = int.MinValue;
        long sum = 0;
        for (int i = 0 ; i < a.Count; i++){
            if (a[i] > max){
                max = a[i];
            }
            
            if (a[i] < min){
                min = a[i];
            }
            sum += a[i];
        }
        Console.Write(sum - max);
        
        Console.WriteLine(" " + (sum - min).ToString());
    }
}
