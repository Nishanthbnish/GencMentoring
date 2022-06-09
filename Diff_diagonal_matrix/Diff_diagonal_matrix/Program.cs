using System;


public class Diagonal
{
    public static int diff(int[,] arr, int n)
    {
        var d1 = 0;
        var d2 = 0;
        for (int i = 0; i < n; i++)
        {
            d1 += arr[i,i];
            d2 += arr[i,n-i-1];
        }
        return Math.Abs(d1 - d2);
    }
   
    public static void Main(String[] args)
    {
        int i, j;
        
        int n = Convert.ToInt16(Console.ReadLine());
        int[,] arr = new int[3, 3];
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write(Diagonal.diff(arr, n));
    }
}