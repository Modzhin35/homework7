// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomArray(int rows, int cols, int min, int max)
{
    int[,] randomArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) randomArray[i, j] = new Random().Next(min, max);
    }
    return randomArray;
}
void PrintRandomArray(int[,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++) Console.Write(randArray[i, j] + "|");
        Console.WriteLine();
    }
}

void AverageOfColumns(int[,] randomArray)
{

    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < randomArray.GetLength(0); i++) summa += randomArray[i, j];
        Console.Write($"{Math.Round(summa / randomArray.GetLength(0), 1)} ");
    }
}

int row = Math.Abs(Input("Введите количество строк: "));
int col = Math.Abs(Input("Введите количество столбцов: "));
int minEl = Input("Введите минимальное значение для генерации случайных чисел: ");
int maxEl = Input("Введите максимальное значение для генерации случайных чисел: ");
int[,] randomArr = GetRandomArray(row, col, minEl, maxEl);
PrintRandomArray(randomArr);
AverageOfColumns(randomArr);