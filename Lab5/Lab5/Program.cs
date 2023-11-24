
using System;                
using System.IO;             

class FileDetails
{
    static void Main()
    {
        Console.WriteLine("Enter numbet of ints in array");
        int b = int.Parse(Console.ReadLine());
        int[] a = new int[b];
        int i = 0;
        foreach (int aboba in a)
        {
            Console.WriteLine("Enter a number for index {0}", i);
            a[i] = int.Parse(Console.ReadLine());
            i++;
        }
        foreach (int aboba in a)
        {
            Console.Write("Your elements are " + aboba);
        }
        int sum = 0;
        foreach (int aboba in a)
        {
            sum = sum + aboba;
        }
        Console.WriteLine("Sum of elements= " + sum);
        int average = sum / a.Length;
        Console.WriteLine("Avearage number is " + average);
        int positivesum = 0;
        int negativesum = 0;
        foreach (int elem in a)
        {
            if (elem < 0)
            {
                negativesum = negativesum + elem;
            }
            else
                if (elem > 0)
            {
                positivesum = positivesum + elem;
            }
        }
        Console.WriteLine("Positive summ is " + positivesum);
        Console.WriteLine("Positive summ is " + negativesum);
        Console.ReadLine();
    }
}
