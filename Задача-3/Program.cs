// Найти максимальное из трех чисел
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine());
int max;

if (a>b)
{
    max=a;
}
else
{
    max=b;
}
if(a>c)
{
    max=a;
}
else
{
    max=c;
}
if(b>c)
{
    max=b;
}
else
{
    max=c;
}
Console.WriteLine("Максимальное число " +max);