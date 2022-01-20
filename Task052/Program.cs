// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
int[,] array = new int[strings, columns];
void ReplaceEvenPlacedNumbers(int[,] onemoretwodimensionalarray)
{
    for (int i = 0; i < onemoretwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < onemoretwodimensionalarray.GetLength(1); j++)
        {
            if (i%2==0&& j%2==0)
            {
                onemoretwodimensionalarray[i, j] = (onemoretwodimensionalarray[i, j])*(onemoretwodimensionalarray[i, j]);
            }
        }
    }
}
FillTwoDimensiounalArray(array);
PrintTwoDimensionalArray(array);
ReplaceEvenPlacedNumbers(array);
Console.WriteLine();
PrintTwoDimensionalArray(array);