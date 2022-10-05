 int N = Convert.ToInt32(Console.ReadLine());
     int count = 0; // счетчик четных цифр
     for (int i = 1; i <= N; i++) 
     {
     int n = i; 
     while (n > 0) 
     {
     int ch = n % 2; 
     if (ch % 2 == 0) 
     {
     count++; // увеличиваем счетчик на 1 при совпадении условия
     }
     n = n / 10; // избавляемся от последней цифры
     }
     }
     Console.WriteLine(count);