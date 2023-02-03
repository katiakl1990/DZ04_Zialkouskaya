// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] String_to_array(string numbers)
{
    numbers = numbers + " ";  
    bool flag = false;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)                         
    {
        if (Char.IsNumber(numbers[i])) flag = true;                  
        else
        {
            if (flag) count++;                                        
            flag = false;
        }
    }

    string work_string = string.Empty;
    int[] array_of_numbers = new int[count];
    count = 0;
    for (int i = 0; i < numbers.Length; i++) 
    {
        if (Char.IsNumber(numbers[i]) || (numbers[i] == '-')) work_string += numbers[i];
        else
        {       
            if (work_string != string.Empty)
            {
                array_of_numbers[count] = int.Parse(work_string);
                count++;
                work_string = string.Empty;
            }
        }
    }

    return array_of_numbers;
}

int count_el_greater_zero(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if (el > 0) counter++;
    }
    return counter;
}

Console.Write("Введите числа через разделитель: ");
string user_string = Console.ReadLine();

int[] array_from_user_string = String_to_array(user_string);
int gretater_than_zero = count_el_greater_zero(array_from_user_string);

Console.Write("Даны числа: ");
Console.WriteLine(String.Join("  ", array_from_user_string));
Console.WriteLine($"Из них {gretater_than_zero} больше 0");
