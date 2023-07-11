int num = new Random().Next(100,1000);
int digit1 = num/10;
int digit2 = digit1%10;
Console.WriteLine($"Вторая цифра числа {num} будет {digit2}");
