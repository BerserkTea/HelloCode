// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
int strings = 5;
int columns = 10;
int[,] matrix = new int[strings, columns];
void FillTwoDimensiounalArray(int[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = new Random().Next(10, 99);
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
void CheckMinSummOfStrings (int[,] somematrix)
{
    int[] summsArray = new int [somematrix.GetLength(0)];
    for (int i = 0; i < somematrix.GetLength(0); i++)
    {
        for (int j = 0; j < somematrix.GetLength(1); j++)
        {
            summsArray[i] = summsArray[i] + somematrix[i,j];
        }
    Console.WriteLine(summsArray[i]);
    }
    int minimalSumm = summsArray[0];
    int minimalPosition = 0;
    for (int k = 0; k < summsArray.Length; k++)
    {
        if (minimalSumm>summsArray[k])
        {
            minimalSumm=summsArray[k];
            minimalPosition = k;
        }
    }
    Console.WriteLine($"Минимальная сумма в {minimalPosition+1} строке равна {minimalSumm}");
} 

FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
CheckMinSummOfStrings(matrix);