// 60. Составить частотный словарь элементов двумерного массива
Console.Clear();
int[,] matrix = new int[10, 100];
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

int[,] SortedFrequencyAnalisMatrix(int[,] freqmatrix)
{
    int[,] resultArray = new int[freqmatrix.GetLength(0) * freqmatrix.GetLength(1), 2];
    int placeNewArray = 0;
    for (int i = 0; i < freqmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < freqmatrix.GetLength(1); j++)
        {
            resultArray[placeNewArray, 0] = freqmatrix[i, j];
            int counterSubmission = 0;
            for (int k = 0; k < freqmatrix.GetLength(0); k++)
            {
                for (int h = 0; h < freqmatrix.GetLength(1); h++)
                {
                    if (freqmatrix[i, j] == freqmatrix[k, h])
                    {
                        counterSubmission++;
                    }
                }
            }
            resultArray[placeNewArray, 1] = counterSubmission;
            placeNewArray++;
        }
    }
    int firstTempDigit = 0;
    int secondTempDigit = 0;
    for (int m = 0; m < resultArray.GetLength(0); m++)
    {
        for (int n = 0; n < resultArray.GetLength(0) - 1; n++) // цикл для сортировки по убыванию повторения
        {
            if (resultArray[n, 1] < resultArray[n + 1, 1])
            {
                firstTempDigit = resultArray[n, 1];
                secondTempDigit = resultArray[n, 0];
                resultArray[n, 1] = resultArray[n + 1, 1];
                resultArray[n, 0] = resultArray[n + 1, 0];
                resultArray[n + 1, 1] = firstTempDigit;
                resultArray[n + 1, 0] = secondTempDigit;
            }
        }
    }
    return resultArray;
}

void PrintAndRemoveRepetition(int[,] resultfreqmatrix)
{
    for (int i = 0; i < resultfreqmatrix.GetLength(0); i++)
    {
        for (int k = i + 1; k < resultfreqmatrix.GetLength(0); k++)
        {
            if (resultfreqmatrix[k, 0] == resultfreqmatrix[i, 0])
            {
                resultfreqmatrix[k, 1] = (Math.Abs(resultfreqmatrix[k, 1])) * (-1);
            }
        }
         Console.WriteLine($"Проверка {resultfreqmatrix[i,0]} {resultfreqmatrix[i,1]} ");   
    }
    for (int j = 0; j < resultfreqmatrix.GetLength(0); j++)
    {
        if (resultfreqmatrix[j, 1] > 0)
        {
            Console.Write($"Число {resultfreqmatrix[j, 0]} встречается {resultfreqmatrix[j, 1]} раз.");
            double digitResult = Convert.ToDouble(resultfreqmatrix[j,1]);
            double sizeResultMatrix = Convert.ToDouble(resultfreqmatrix.GetLength(0));
            double percentageResult = Math.Round(((digitResult/sizeResultMatrix)*100),2);
            Console.WriteLine($"Частота {percentageResult} %");
        }
    }
}
FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
// PrintTwoDimensionalArray(SortedFrequencyAnalisMatrix(matrix));
PrintAndRemoveRepetition(SortedFrequencyAnalisMatrix(matrix));
