﻿// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

Console.Clear();

int[] get_random_array(int size, int minValue, int maxValue)
{
    int[] random_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        random_array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return random_array;
}

void bubble_sorting(int[] array)
{
    int template = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                template = array[j];
                array[j] = array[j + 1];
                array[j + 1] = template;
            }
        }
    }
}


int[] array = get_random_array(10, -10, 10);
Console.WriteLine(string.Join(" ", array));

bubble_sorting(array);
Console.WriteLine(string.Join(" ", array));