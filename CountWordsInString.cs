using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        s = s.Substring(1);
        var total = s.ToCharArray().Where(x => Char.ToUpper(x) == x).Count() + 1;
        Console.WriteLine(total);
    }
}
