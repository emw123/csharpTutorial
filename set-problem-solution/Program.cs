using System;
using System.Collections.Generic;
 
class states {
 
    // Main Method
    static public void Main()
    {
 
        HashSet<string> stateshash = new HashSet<string>();
 
        stateshash.Add("Alabama");
        stateshash.Add("Alaska");
        stateshash.Add("Arizona");
        stateshash.Add("Arkansas");

        foreach(var val in stateshash)
        {
            Console.WriteLine(val);
        }
    }
}