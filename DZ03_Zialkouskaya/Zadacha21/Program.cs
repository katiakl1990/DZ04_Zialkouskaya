// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату a1: ");
int a1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату a2: ");
int a2 = int.Parse(Console.ReadLine()!);

double resault = Math.Sqrt((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((a2-a1),2)));
//resault = Math.Round(resault,2);

Console.WriteLine($"Расстояние между заданными точками -> {resault:F2}");
