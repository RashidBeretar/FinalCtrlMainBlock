// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array)
{
    var output_strint = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) output_strint += $"“{array[i]}”, ";
        else output_strint += $"“{array[i]}”";
    }
    output_strint += "]";

    Console.WriteLine(output_strint);
}

string[] GetStringArrayFromConsole()
{
    Console.WriteLine("Сколько будет элементов?");
    int length = Convert.ToInt32(Console.ReadLine());
    var result_array = new string[length];
    for (int i = 0; i < length; i++)
    {
        result_array[i] = Convert.ToString(Console.ReadLine());
    }
    return result_array;
}

string[] array_input = { "Hello", "2", "world", ":-)" };
// string[] array_input = { "1234", "1567", "-2", "computer science" };
// string[] array_input = { "Russia", "Denmark”", "Kazan" };

int result_array_length = 0;
int j = 0;

for (int i = 0; i < array_input.Length; i++)
{
    if (array_input[i].Length <= 3)
    {
        result_array_length++;
    }
}

var result_array = new string[result_array_length];

for (int i = 0; i < array_input.Length; i++)
{
    if (array_input[i].Length <= 3)
    {
        result_array[j] = array_input[i];
        j++;
    }
}

PrintArray(result_array);