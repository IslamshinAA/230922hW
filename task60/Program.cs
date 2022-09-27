// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine($" Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Введите размер массива X x Y x Z:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
void InputMatrix(int[,,] array3D)
{
  int[] arr = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    arr[i] = new Random().Next(10, 18);
    number = arr[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (arr[i] == arr[j])
        {
          arr[i] = new Random().Next(10, 20);
          j = 0;
          number = arr[i];
        }
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
        
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = arr[count];
        count++;
      }
    }
  }
}

void PrintMatrix (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $" {array3D[i,j,k]}  ");
         Console.Write($"({i}, {j}, ");
        Console.Write( $"{k}) ");
      }
      Console.WriteLine();
    }
  }
}
int[,,] array3D = new int[x, y, z];
InputMatrix(array3D);
PrintMatrix(array3D);
InputMatrix(array3D);