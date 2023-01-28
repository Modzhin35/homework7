// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Intput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetRandomArray(int rows, int cols, int min, int max)
{
    double[,] randomArray = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) randomArray[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
    }
    return randomArray;
}

void PrintRandomArray(double[,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++) Console.Write(randArray[i, j] + "|");
        Console.WriteLine();
    }
}
int row = Intput("Введите количество строк: ");
int col = Intput("Введите количество столбцов: ");
int minEl = Intput("Введите минимальное значение для генерации случайных чисел: ");
int maxEl = Intput("Введите максимальное значение для генерации случайных чисел: ");
PrintRandomArray(GetRandomArray(row, col, minEl, maxEl));