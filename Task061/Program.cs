// 61. Найти произведение двух матриц

int[,] firstMatrix = new int[5, 10];
int[,] secondMatrix = new int[10, 12];
void FillTwoDimensiounalArray(int[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = new Random().Next(1, 9);
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
int[,] CompositionTwoMatrix(int[,] onematrix, int[,] twomatrix)
{
    int[,] compositionMatrix = new int[onematrix.GetLength(0), twomatrix.GetLength(1)];
    if (onematrix.GetLength(1) == twomatrix.GetLength(0))
    {
        for (int i = 0; i < compositionMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < compositionMatrix.GetLength(1); j++)
            {
                for (int l = 0; l < onematrix.GetLength(0); l++)
                {
                    compositionMatrix[i,j]=onematrix[i,l]*twomatrix[l,j];
                    // Console.WriteLine(compositionMatrix[i,j]);
                }
            }
        }
        return compositionMatrix;
    }
    else
    {
        Console.WriteLine("Умножение не имеет смысла");
        return compositionMatrix;
    }
}
FillTwoDimensiounalArray(firstMatrix);
FillTwoDimensiounalArray(secondMatrix);
PrintTwoDimensionalArray(firstMatrix);
PrintTwoDimensionalArray(secondMatrix);
PrintTwoDimensionalArray(CompositionTwoMatrix(firstMatrix, secondMatrix));