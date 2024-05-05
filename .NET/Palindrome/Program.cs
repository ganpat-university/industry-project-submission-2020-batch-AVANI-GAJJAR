using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string : ");
        string st = Console.ReadLine();
        string rev_st = "";
        for (int i = st.Length - 1; i >= 0; i--)
        {
            rev_st += st[i];
        }
        if (st == rev_st)
        {
            Console.WriteLine("It is a palindrom");
        }
        else
        {
            Console.WriteLine("It is not a palindrom");
        }
    }
}