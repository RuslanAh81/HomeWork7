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
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2dArray()
{ 
      Console.WriteLine("введите количество строк m :");
    int rows = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите количество столбцов n :");
    int columns = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите минимальный диапозон :");
    int minValue = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("введите максимальный диапозон :");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,]array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
      return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   

    }
}

void  FoundElement(int[,] array)
{
     Console.WriteLine("Введите номер строки :");
     int m = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите номер столбца :");
     int n = Convert.ToInt32(Console.ReadLine());
       
    if (m < array.GetLength(0) || n < array.GetLength(1))
       
        Console.Write (array[m,n] );
           
    else
        Console.Write("Числа с таким индексом в массиве нет");
    
}
int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FoundElement(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2dArray()
{ 
      Console.WriteLine("введите количество строк m :");
    int rows = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите количество столбцов n :");
    int columns = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите минимальный диапозон :");
    int minValue = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("введите максимальный диапозон :");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,]array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
      return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   
    }


}


void SrednArifm(int[,] array)
{
    // double sredn = 0;
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)]; 
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j]; 
        }
        newArray[j] = Math.Round(sum / array.GetLength(0), 1); 
        sum = 0;
        Console.Write(newArray[j] + "  ");
    }
        
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SrednArifm(myArray);
