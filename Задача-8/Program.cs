// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n = 48;
int a1 = n / 10;
int a2 = n % 10 ;

if ( a1 == a2 )
{
    
    Console.WriteLine ("Первая и вторая цифра в числе равны ");
}

else if (a1>a2)
{
    
    Console.WriteLine ("Первая цифра числа больше");
}
else
{
    
    Console.WriteLine ("Вторая цифра числа больше");
}