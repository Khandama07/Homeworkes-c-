Console.WriteLine("Введите число A ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b){
    Console.WriteLine("Числа равны");
}
if (a > b) {
    Console.WriteLine("max " + a);
    Console.WriteLine("min " + b);
}
if (a < b) {
    Console.WriteLine("max " + b);
    Console.WriteLine("min " + a);
}
