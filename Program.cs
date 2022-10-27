// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray()
{ 
      Console.WriteLine("введите количество строк m :");
    int rows = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите количество столбцов n :");
    int columns = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите минимальный диапозон :");
    int minValue = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("введите максимальный диапозон :");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,]array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            {
            double cel = new Random(). Next (minValue,maxValue);
            double drobn =new Random ().NextDouble();
            array[i,j] = Math.Round(cel + drobn, 1);
            }
    }
      return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   
    }


}

double [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
