// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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
int[,] ReplaceStringsColumns(int[,] somematrix)
{
    int [,] replacedMatrix = new int [somematrix.GetLength(0),somematrix.GetLength(1)];
    if (somematrix.GetLength(0) == somematrix.GetLength(1))
    {
        for (int i = 0; i < somematrix.GetLength(0); i++)
        {
            for (int j = 0; j < somematrix.GetLength(1); j++)
            {
                replacedMatrix[j,i]=somematrix[i,j];
            }
        }
    Console.WriteLine("Массив изменен");
    return replacedMatrix;
    }
    else 
    {
    Console.WriteLine("Указанный массив не удовлетворяет условию");
    Console.WriteLine("");
    return somematrix;
    }
}
int[,] matrix = new int[strings, columns];
FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
Console.WriteLine("");
PrintTwoDimensionalArray(ReplaceStringsColumns(matrix));