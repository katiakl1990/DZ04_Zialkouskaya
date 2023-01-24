// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
int result = 0;
while (num1 > 0)
{
   result = result * 10 + num1 % 10; num1 /= 10;
}
if (num == result)
{
    Console.WriteLine($"Число {num} -> палиндром");
}
else
{
    Console.WriteLine($"Число {num} -> не является палиндромом");
}
