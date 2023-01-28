// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

void CheckAvailabilityElement(int[,] randArray, int elementNumber)
{
    int summaElementov = 0;
    int serchElement = 0;
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {

            Console.Write($"{randArray[i, j]} ");
            summaElementov++;
            if (summaElementov == elementNumber) serchElement = randArray[i, j];
        }
        Console.WriteLine();
    }

    if (elementNumber <= summaElementov)
    {
        Console.WriteLine($"Всего в массиве {summaElementov} элементов.");
        Console.WriteLine($"Элемент с порядковым номером {elementNumber} есть в заданном массиве.");
        Console.WriteLine($"Его значение = {serchElement}.");
    }
    else Console.Write($"Элемента с порядковым номером {elementNumber} нет в заданном массиве.");
}

int row = Math.Abs(Input("Введите количество строк: "));
int col = Math.Abs(Input("Введите количество столбцов: "));
int minEl = Input("Введите минимальное значение для генерации случайных чисел: ");
int maxEl = Input("Введите максимальное значение для генерации случайных чисел: ");
int elementNum = Math.Abs(Input("Введите порядковый номер элемента: "));
CheckAvailabilityElement(GetRandomArray(row, col, minEl, maxEl), elementNum);