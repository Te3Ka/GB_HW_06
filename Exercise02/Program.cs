/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;

k1 * x + b1 = k2 * x + b2
k1 * x = k2 * x + b2 - b1
k1 * x - k2 * x = b2 - b1
x (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Вычисление координат точки пересечения
void Coordinates(double k1, double b1, double k2, double b2)
{
    if ((b1 == b2) && (k1 == k2))
    {
        Console.WriteLine("Прямые совпадают. Количество точек пересечений бесконечно.");
        return;
    }
    else if ((k1 == k2) && (b1 != b2))
    {
        Console.WriteLine("Прямые параллельны. Точки пересечения не существует.");
        return;
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересчения: T = ({x}, {y})");
    }
}

//Запрос на коэффициенты двух прямых
double GetVar(string name)
{  
    Console.Write($"Введите значение числа {name}: ");
    double.TryParse(Console.ReadLine(), out double num);
    return num;
}

double b1 = GetVar("b1");
double k1 = GetVar("k1");
double b2 = GetVar("b2");
double k2 = GetVar("k2");

Coordinates(k1, b1, k2, b2);

Author();