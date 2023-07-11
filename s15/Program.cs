// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine($"Введите число, обзначающее день недели: ");
int n = int.Parse(Console.ReadLine());
if (n>0 && n<8)
{
    if (n == 6 || n == 7)
    {
    Console.WriteLine($"Это выходной день");
    }
    else
    {
     Console.WriteLine($"Это будни");
     }
}
else
{
    Console.WriteLine($"error");
}