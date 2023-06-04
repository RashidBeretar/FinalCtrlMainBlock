// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// var array_input = {“Hello”, “2”, “world”, “:-)”};

int result_array_length = 0;
int j = 0;

string[] array_input = { "Hello", "2", "world", ":-)" };

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