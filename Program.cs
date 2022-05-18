// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

double minimal = array[0, 0];
double iMin = 0;
double jMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < minimal)
        {
            minimal = array[i, j];
            iMin = i;
            jMin = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент массива это {minimal}");

Console.WriteLine(iMin);
Console.WriteLine(jMin);
int posI = 0;
int posJ = 0;


double[,] matrix = new double [m - 1, n - 1];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        if (posI == iMin)
        {
            posI++;
        }
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (posJ == columns)
            {
                posJ++;
            }
            matrix[rows, columns] = array[posI, posJ];
            posJ++;
        }
        posJ = 0;
        posI++;
    }
    PrintArray(matrix);




//МЕТОД ПЕЧАТИ МАССИВА
void PrintArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}
// МЕТОД ЗАПОЛНЕНИЯ МАССИВА
void FillArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,10); 
        }
        Console.WriteLine();
    }
}