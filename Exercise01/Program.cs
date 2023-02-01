/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Печать массива на экран
void PrintArray(int[] arrayPruint)
{
    Console.Write("[");
    for (int index = 0; index < arrayPruint.Length; index++)
    {
        if (index == (arrayPruint.Length - 1))
            Console.WriteLine($"{arrayPruint[index]}]");
        else
            Console.Write($"{arrayPruint[index]}, ");
    }
}

//Запрос на i-ый элемент массива
int GetVar(int i)
{  
    Console.Write($"Введите значние {i}-го элемента: ");
    int.TryParse(Console.ReadLine(), out int num);
    return num;
}

int GetArray(int length)
{
    int[] newArray = new int[length];
    int pos = 0;
    for (int i = 0; i < length; i++)
    {
        newArray[i] = GetVar(i);
        if (newArray[i] > 0)
            pos++;
    }
    PrintArray(newArray);
    return pos;
}

//Запрос на количество элементов массива
int GetVarLengthArray()
{  
    Console.Write("Сколько чисел Вы хотите ввести? ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Массив не может быть создан. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа считает количество чисел больше 0, которые Вы введёте с клавиатуры.");
int length = GetVarLengthArray();
Console.WriteLine($"Было введено положтельных чисел: {GetArray(length)}");

Author();