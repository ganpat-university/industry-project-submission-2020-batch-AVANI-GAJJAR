using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string st = "I am a .Net Developer";
        Console.WriteLine("Original String: " + st);
        string rev_st = "";
        for (int i = st.Length - 1; i >= 0; i--)
        {
            rev_st += st[i];
        }
        Console.WriteLine("Reversed String: " + rev_st);
    }
}