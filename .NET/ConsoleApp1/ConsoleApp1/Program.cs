// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 5; i++)
        {

            for (int j = 1; j <= 10; j++)
            {
                int b = (i * j);
                string table = string.Concat(i, "x", j, "=", b);

                Console.WriteLine(table);
            }
            Console.WriteLine("");
        }
    }
}