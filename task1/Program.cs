int a = -3;
int b = -9;
int max = a;
int min = b;

if (a < b) 
{
    max = b;
    min = a;
}

Console.WriteLine(max);
Console.WriteLine(min);