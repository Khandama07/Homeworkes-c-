Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

string res = "";

for (int i = 1; i < num; i++)
{
    if (i % 2 == 0)
    {
        res = res + " " + i.ToString();
    }
}

Console.WriteLine("Четные числа " + res);