// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string[] myArray(string step)
{
    string[] elements = new string [8];
    elements = step.Split(",");
    return elements;
}

void divide(string[] elements)
{
    Console.WriteLine(String.Join(", ", elements));  
}

void main()
{
    Console.WriteLine("Введите 8 чисел через запятую: ");
    string num = Console.ReadLine()!;
    divide(myArray(num));
}

main();
