// 49. Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите число строк");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

void FillTwoDimensiounalArray(double[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = (new Random().Next(1, 99)+Math.Round((new Random().NextDouble()),2));
        }
    }
}
void PrintTwoDimensionalArray (double[,] anothertwodimensionalarray)
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
double[,] array = new double[strings, columns];
FillTwoDimensiounalArray(array);
PrintTwoDimensionalArray(array);
