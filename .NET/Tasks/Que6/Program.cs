// See https://aka.ms/new-console-template for more information
using System.Transactions;

Dictionary<int, string> dict1 = new Dictionary<int, string>();
dict1.Add(1, "Car");
dict1.Add(2, "Bus");
dict1.Add(3, "Ship");
dict1.Add(4, "Jeep");

Console.WriteLine("Enter a key:");
int a=Convert.ToInt32(Console.ReadLine());

foreach (KeyValuePair<int, string> i in dict1)
{

    if (i.Key == a)
    {
        Console.WriteLine("Yes Key found ");
    }
}

Console.WriteLine("Enter a Value:");
string val = (Console.ReadLine());
foreach (KeyValuePair<int, string> i in dict1)
{
    if (i.Value == val)
{
    Console.WriteLine("Yes Data found ");
}
}