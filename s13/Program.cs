// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine($"Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n>100)
{
   while (n>1000)
   {
   n = n/10;
   }
   int resultat = n%10;
   Console.WriteLine($"Третья цифра получится {resultat}");
}
else
{
    Console.WriteLine($"Третьей цифры в числе {n} нет");
}