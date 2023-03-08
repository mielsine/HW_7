// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int numRows = SetNumber("Rows: ");
int numColumns = SetNumber("Columns: ");

var matrix = GetMatrix(numRows, numColumns);
Print(matrix);

int SetNumber(string numberName)
{
    System.Console.Write($"Enter number {numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double [,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(-100, 100) /10;

        }
    }
    return matrix;
}

void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(string.Format("{0:F1}", matrix[i, l]) + " ");
        }
        System.Console.WriteLine();
    }
}