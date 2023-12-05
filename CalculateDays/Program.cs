using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input Sam daily exercises: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Kelly daily exercises: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input difference: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Needed days: ");
        Console.WriteLine(CalculateDays(a,b,c));
    }
    public static int CalculateDays(int a, int b, int c)
{
    int p1 = 0 + c;
    int p2 = 0;
    int days = 0;

    for (int i = 1; p1 + 1 > p2; i++)
    {
        p1 += a;
        p2 += b;
        days = i;
    }

    return days;
}

}