// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] firstMatrix = new int[25, 25];
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
int[] SearchMinInTwoDimensionalArray(int[,] somematrix)
{
    int[] resultedMinStringColumnCoordinates = new int[2];
    int min = somematrix[0, 0];
    int minString = 0;
    int minColumn = 0;
    for (int i = 0; i < somematrix.GetLength(0); i++)
    {
        for (int j = 0; j < somematrix.GetLength(1); j++)
        {
            if (somematrix[i, j] < min)
            {
                min = somematrix[i, j];
                minString = i;
                minColumn = j;
            }

        }
    }
    resultedMinStringColumnCoordinates[0] = minString;
    resultedMinStringColumnCoordinates[1] = minColumn;
    Console.WriteLine($"String {minString} column {minColumn}");
    return resultedMinStringColumnCoordinates;
}
int[,] EraseIntersectionMinStringColumn(int[,] somematrixtoerase, int[] whtichcoordinateserasearray)
{
    int[,] modifiedMatrix = new int[somematrixtoerase.GetLength(0) - 1, somematrixtoerase.GetLength(1) - 1];
    for (int i = 0; i < modifiedMatrix.GetLength(0); i++)
    {
        int test1 = i;
        if (i >= whtichcoordinateserasearray[0])
        {
            test1 = test1 + 1;
        }
        for (int j = 0; j < modifiedMatrix.GetLength(1); j++)
        {
            int test2 = j;
            if (j >= whtichcoordinateserasearray[1])
            {
                test2 = test2 + 1;
            }
            modifiedMatrix[i, j] = somematrixtoerase[test1, test2];
        }
    }

    // for (int k = whtichcoordinateserasearray[0] + 1; k < modifiedMatrix.GetLength(0); k++)
    // {
    //     for (int l = whtichcoordinateserasearray[1] + 1; l < modifiedMatrix.GetLength(1); l++)
    //     {
    //         modifiedMatrix[(k - 1), (l - 1)] = somematrixtoerase[k, l];
    //     }
    // }
    return modifiedMatrix;
}
FillTwoDimensiounalArray(firstMatrix);
PrintTwoDimensionalArray(firstMatrix);
Console.WriteLine("");
PrintTwoDimensionalArray(EraseIntersectionMinStringColumn(firstMatrix, SearchMinInTwoDimensionalArray(firstMatrix)));