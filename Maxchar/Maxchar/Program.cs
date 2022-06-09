using System;
using System.IO;
using System.Linq;
using System.Collections;



public class Program
{
    public static void Main(String[] args)
    {
        
        var k = Console.ReadLine();
        char[] tempArray = k.ToCharArray();
         Array.Sort(tempArray);
        var s = new String(tempArray);
        var n = s.Length;
        var max_count = 0;
        var count = 1;
        var ans = '-';
        var c = 1;
        for (int i = 1; i <= n; i++)
        {
            if ((i == n) || (s[i] != s[i - 1]))
            {
                if (max_count < count)
                {
                    max_count = count;
                    ans = s[i - 1];
                    c = count;
                }
                count = 1;
            }
            else
            {
                count++;
            }
            
        }
        Console.WriteLine("Maximum occurring character is " + ans.ToString() + " " + c.ToString());
        
    }
}
