// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void sum_num(int number)
{   
    int result = 0;
    int initial_number = number;    
    while (number > 0)              
    {
        result += number % 10;
        number /= 10; 
    }
    Console.WriteLine($"Сумма цифр в числе {initial_number} = {result}");
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
sum_num(number);