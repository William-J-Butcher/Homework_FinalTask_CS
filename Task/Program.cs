// ЗАДАЧА:

// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // Пользователь задает длинну массива.
string[] array = new string[n]; 

for (int i = 0; i < n; i++)                 // Цикл для заполнения массива элементами пользователем.
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    array[i] = Console.ReadLine()!;
}

void PrintArray1(string[] array)          // Функция вывода несортированного массива пользователя.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
}

void PrintArray2(string[] array)         // Функция вывода нового, отсортированного массива.
{
    for (int i = 0; i < array.Length; i++)
    {  
        if(array[i].Length == 0) Console.Write(" ");      // -> Данное условие используется для аккуратного оформления 
                                                          //    пустого массива, если пользователь ничего не введет.

        else if(array[i].Length <= 3) Console.Write($"\"{array[i]}\",");

        else if(array[i].Length > 3) Console.Write(" "); // -> Данное условие используется для аккуратного оформления 
                                                         //    пустого массива, если все элементы массива более 3-х симфолов.
    }
}

Console.Write("[");
PrintArray1(array);
Console.Write("\b\b] -> ");

Console.Write("[");
PrintArray2(array);
Console.Write("\b\b]");

