// Задача “со звездочкой”: 
// Напишите функцию, которая принимает одно число - высоту елочки 
// и рисует ее в консоли звездочками. (Пример см. презентацию)

Console.Clear();

Console.WriteLine("Введите высоту елочки: ");
int height = int.Parse(Console.ReadLine()!);

for (int i = height; i >= 0; i--)
    {
        
        for (int j = height - i; j < height; j++)
        {
            Console.Write(" ");
        }
        if (i == height)
        {
            Console.WriteLine("*");
            continue;
        }
        for (int j = 0; j < height - i; j++)
        {
            Console.Write("*");
        }
        Console.Write("*");
        for (int j = 0; j < height - i; j++)
        {
            Console.Write("*");
        }
            Console.WriteLine();
    }
    for (int i = height; i > 0; i--)
    {
        Console.Write(" ");
    } 
Console.ReadKey(); 