// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами, округлёнными до одного знака.
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task1()
{
    int rows = 4;
    int columns = 5;
    double[,] doubles = new double[rows, columns];
    int minValue = -9;
    int maxValue = 9;

    for (int i = 0; i < doubles.GetLength(0); i++)
    {
        for (int j = 0; j < doubles.GetLength(1); j++)
        {
            Random rnd = new();
            doubles[i, j] = rnd.NextDouble() * (maxValue - minValue) - maxValue;
            doubles[i, j] = Math.Round(doubles[i, j], 1);
        }
    }
    for (int i = 0; i < doubles.GetLength(0); i++)
    {
        Console.WriteLine("\t");
        for (int j = 0; j < doubles.GetLength(1); j++)
        {
            Console.Write($"{doubles[i, j]}\t");
        }
    }
}



// Напишите программу, которая на вход принимает индексы элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

void Task2()
{
    int rows = 4;
    int columns = 5;
    int[,] ints = new int[rows, columns];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Random rnd = new();
            ints[i, j] = rnd.Next(-100, 100);

        }
    }
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        Console.WriteLine("\t");
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write($"{ints[i, j]}\t");
        }
    }
    
    int inputRow = Input("\nВведите значение строки: ") - 1;
    int inputColumn = Input("Введите значение столбца: ") - 1;

    if (inputRow >= 0 && inputRow < rows
        && inputColumn >= 0 && inputColumn < columns) {
            Console.WriteLine($"Результат: {ints[inputRow, inputColumn]}");
        }
    else Console.WriteLine("Такого элемента массива нет");
}
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

void Task3()
{


    int rows = 4;
    int columns = 5;
    int[,] ints = new int[rows, columns];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Random rnd = new();
            ints[i, j] = rnd.Next(0, 10);

        }
    }
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        Console.WriteLine("\t");
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write($"{ints[i, j]}\t");
        }
    }
    Console.WriteLine();
    for (int j = 0; j < ints.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            result = ints[i, j] + result;
        }
    
        Console.Write($"{result / ints.GetLength(0)}\t");
    }

}
Console.Clear();
Task3();