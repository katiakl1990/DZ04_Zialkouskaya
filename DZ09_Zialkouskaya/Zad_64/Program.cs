// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumbers(int n)
{
    if(n == 1) return "1";
    else
    {
        return n.ToString() + ", " + GetNumbers(n - 1);
    }
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);

    Console.WriteLine(GetNumbers(num));
}
Main();
