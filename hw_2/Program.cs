Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}


if (max < c)
{
    max = c;
}
Console.WriteLine("max " + max);