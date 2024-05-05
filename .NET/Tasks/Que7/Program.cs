using System.Runtime.Serialization.Formatters;

Console.WriteLine("Enter the value of n:");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n*n; i++)
{
    if (i%n==0)
    Console.Write(i+"\t");
}
    int[,] a = new a[];
Console.WriteLine(n);
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine("");
}