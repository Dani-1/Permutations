using System;

public class Permutations
{
    public int size;
    // Helper method for outputting an array.
    private static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    // Helper method for invoking Generate.
    private static void Generate(int size, string[] array)
    {

        if (size == 1)
            PrintArray(array);
        else
        {
            Generate(size - 1, array);


            for (int i = 0; i < (size-1); i++)
            {


                if (size % 2 == 1)
                {

                    string temp = array[0];
                    array[0] = array[size - 1];
                    array[size - 1] = temp;
                }

                // If size is even, swap ith and last 
                // element 
                else
                {
                    string temp = array[i];
                    array[i] = array[size - 1];
                    array[size - 1] = temp;
                }
                Generate(size - 1, array);


            }
        }
    }

    public static void Main(string[] args)
    {
       // string[] a = { "qaz", "wsx", "edc" };

        Generate(args.Length, args);
    }

    /*public static void Main()
    {
        string[] args = { "qaz", "wsx", "edc" };
        Generate(args.Length, args);
        Console.ReadLine();

    }*/

}
