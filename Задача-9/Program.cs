Console.WriteLine("введите трехзначное число "); // от 100 до 999
int a = int.Parse(Console.ReadLine());

int result = (a/10) % 10;
 Console.WriteLine(result);

  // int delete = result;
// var str = a.ToString();
// a = int.Parse(str.Remove(str.Length - delete, 1));