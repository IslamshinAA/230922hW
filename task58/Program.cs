// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

 Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}
void ResultMatrixs(int [,] array, int [,] arr)
{   
    Console.WriteLine();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int res;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res = array[i,j] * arr[i,j];
            Console.Write(res + " \t"); 
        }
        Console.WriteLine();
    }
    
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
int[,] arr = new int[n, m];
InputMatrix(array);
PrintMatrix(array);
InputMatrix(arr);
PrintMatrix(arr);
ResultMatrixs(array,arr);