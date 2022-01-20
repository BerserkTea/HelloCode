// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

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
            sometwodimensionalarray[i, j] = i+j;
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
FillTwoDimensiounalArray(array);
PrintTwoDimensionalArray(array);