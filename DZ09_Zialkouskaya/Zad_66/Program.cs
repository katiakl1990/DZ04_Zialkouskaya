// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumNumbers(int m, int n)
{
    if(m == n) return n;
    else
    {
        return GetSumNumbers(m, n - 1) + n;
    }
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите первое число: ");
    int first = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите второе число: ");
    int second = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Сумма элементов данного промежутка равна -> {GetSumNumbers(first, second)}");
}
Main();

