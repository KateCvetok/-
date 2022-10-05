Console.WriteLine("введите первое число");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
double b = double.Parse(Console.ReadLine());
double c = a/b;

if (a % b != 0)
{
    Console.WriteLine("Число b не является кратным числу a");
   }
else
{
    Console.WriteLine("Число b  является кратным числу a");
    
}
