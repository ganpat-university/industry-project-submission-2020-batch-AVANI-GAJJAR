//Remove duplicate characters from a string? Input string needs to be taken from user. 

using System.Globalization;

Console.WriteLine("Enter the string:");
string str1= Console.ReadLine();
string final = "";

str1 = str1.Replace(" ", string.Empty);
while(str1.Length > 0)
{
    int temp = 0;
    final+=str1[0];
    for (int i = 0;i < str1.Length; i++)
    {
        if (str1[0] == str1[i])
        {
            str1 = str1.Replace(str1[0].ToString(), string.Empty);
            //Console.WriteLine(str1);
        }
    }
    final += str1[0];
    str1 = str1.Replace(str1[0].ToString(), string.Empty);
}
Console.WriteLine(final);