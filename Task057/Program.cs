//57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива. 
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
void MaxMinCorrectionStringArray(int[,] onemorematrix)
{
    for (int i = 0; i < onemorematrix.GetLength(0); i++)
    {
        for (int j = 0; j < onemorematrix.GetLength(1); j++)
        {
            int replaceDigits = 0;
            for (int k = 0; k < onemorematrix.GetLength(1) - 1; k++)
            {
                if (onemorematrix[i, k] < onemorematrix[i, k + 1])
                {
                    replaceDigits = onemorematrix[i, k];
                    onemorematrix[i, k] = onemorematrix[i, k + 1];
                    onemorematrix[i, k + 1] = replaceDigits;
                }
            }
        }
    }
}

FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
MaxMinCorrectionStringArray(matrix);
Console.WriteLine();
PrintTwoDimensionalArray(matrix);