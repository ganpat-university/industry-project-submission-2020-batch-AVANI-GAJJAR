// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

int[] a= {10,90,21,123,32};
int[] b = new Integer;
int t1, t2, t3;
t1=0; t2=0; t3=0;
for (int i=0; i<a.Length; i++)
{
    if (a[i]>t1)
    {
        t1= a[i];
        Console.WriteLine(t1);
    }
    if (a[i]>t2 && t2>t1)
    {
        t2= a[i];
        continue;
    }
    if (a[i]>t3 && t2 > t1 && t3 > t2)
    {
        t3= a[i];
        continue;
    }
}
Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

for (int i=0;i<a.Length;i++)
{
    for (int j=i;j<a.Length;j++)
    {
        if (a[i] >= a[j])
        {
            Console.WriteLine(Convert.ToInt32(b.Append(a[i])));
        }
    }
}
Console.WriteLine(b);