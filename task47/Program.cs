int Intput (string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GetRandomArray (int rows, int cols, int min, int max){
    double [,] randomArray = new double [rows, cols];
    for(int i=0; i<rows; i++){
        for (int j=0; j<cols; j++)randomArray[i, j]=Math.Round(new Random().Next(min, max)+new Random().NextDouble(), 1);
    }
    return randomArray;
}

void PrintRandomArray (double [,] randArray){
    for(int i=0; i<randArray.GetLength(0); i++){
        for(int j=0; j<randArray.GetLength(1); j++) Console.Write(randArray[i, j]+"|");
        Console.WriteLine();
    }
}
int row = Intput("Введите количество строк: ");
int col = Intput("Введите количество столбцов: ");
int minEl = Intput("Введите минимальное значение для генерации случайных чисел: ");
int maxEl = Intput("Введите максимальное значение для генерации случайных чисел: ");
PrintRandomArray(GetRandomArray(row, col, minEl, maxEl));