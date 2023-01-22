// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. (Цифры считать справа налево).
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Ведите число: ");
int number = int.Parse(Console.ReadLine());

int x100 = number / 100 ;

if (x100 != 0) 
{
    int num3 = x100 % 10 ;
    Console.WriteLine($"Третья цифра числа {num3}");
}
else
Console.WriteLine ("Третьей цифры нет");
