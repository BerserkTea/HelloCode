// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.WriteLine("Введите число строк");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

void FillTwoDimensiounalArray(int[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = new Random().Next(1, 99);
        }
    }
}
void PrintTwoDimensionalArray(int[,] anothertwodimensionalarray)
{
    for (int i = 0; i < anothertwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < anothertwodimensionalarray.GetLength(1); j++)
        {
            Console.Write($"{anothertwodimensionalarray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void AverageOfColumnsMatrix (int[,] onemoretwodimensionalarray)
{
     for (int j = 0; j < onemoretwodimensionalarray.GetLength(1); j++)
    {
        double averagecolumn = 0;
        double counter = 0;
        for (int i = 0; i < onemoretwodimensionalarray.GetLength(0); i++)
        {
            averagecolumn = averagecolumn+onemoretwodimensionalarray[i,j];
            counter++;
        }
        // Console.WriteLine(counter);
        // Console.WriteLine(averagecolumn);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца равно {Math.Round((averagecolumn/counter),2)}");
    }
}
int[,] array = new int[strings, columns];
FillTwoDimensiounalArray(array);
PrintTwoDimensionalArray(array);
AverageOfColumnsMatrix(array);