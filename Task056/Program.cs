// 56. Написать программу, которая обменивает элементы первой строки и последней строки
int strings = 7;
int columns = 8;
int[,] matrix = new int[strings, columns];
void FillTwoDimensiounalArray(int[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = new Random().Next(1, 10);
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
void ReplaceFirstLastsStrings(int[,] onemorematrix)
{
    for (int j = 0; j < onemorematrix.GetLength(1); j++)
    {
        int replacer = 0;
        int positionToReplace = (onemorematrix.GetLength(0))-1;
        replacer = onemorematrix[0, j];
        onemorematrix[0, j] = onemorematrix[positionToReplace,j];
        onemorematrix[positionToReplace, j] = replacer;
    }
}
FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
Console.WriteLine();
ReplaceFirstLastsStrings(matrix);
PrintTwoDimensionalArray(matrix);