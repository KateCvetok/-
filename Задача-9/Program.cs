int x;
int y;
int z;
int a;
Console.Write("Введите трёхзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
while ((a > 999) | (a < 100))
{
   Console.Write("Ошибка!Введите число от 100 до 999: ");
   a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}
z = a / 100;
x = (a / 10)%10;
y = a % 10;
Console.WriteLine("Вторая цифра " +x);
string MyString = "zxy";
Console.WriteLine(MyString.Remove(1,1));

// Здесь не поняла как удалить вторую цифру. Подскажите пожалуйста
