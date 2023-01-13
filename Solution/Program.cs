// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Enter array's size: ");
int size = int.Parse(Console.ReadLine());

string[] array = Array(size);
string[] Array(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter {i + 1}/{size} element of array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int maxStringLength = 3;

string[] arrayCut = maxStringLength3(size);
string[] maxStringLength3(int size)
{
    string[] arrayCut = new string[size];
    for (int i = 0; i < arrayCut.Length; i++)
    {
        if (array[i].Length <= maxStringLength)
            arrayCut[i] = array[i];
    }
    return arrayCut;
}

Console.WriteLine($"A new array of strings with length less than or equal to {maxStringLength}:[{String.Join(" ", arrayCut)}]");