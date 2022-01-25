// 60. Составить частотный словарь элементов двумерного массива
Console.Clear();
int[,] matrix = new int[2,5];
void FillTwoDimensiounalArray(int[,] sometwodimensionalarray)
{
    for (int i = 0; i < sometwodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < sometwodimensionalarray.GetLength(1); j++)
        {
            sometwodimensionalarray[i, j] = new Random().Next(1,10);
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

int[,] FrequencyAnalisMatrix (int[,] freqmatrix)
{
int [,] resultArray = new int [freqmatrix.GetLength(0)*freqmatrix.GetLength(1),2];
int placeNewArray = 0;
for (int i = 0; i < freqmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < freqmatrix.GetLength(1); j++)
            {
                resultArray[placeNewArray,0] = freqmatrix[i,j];
                int counterSubmission=0;
                for (int k = 0; k < freqmatrix.GetLength(0); k++)
                {
                    for (int h = 0; h < freqmatrix.GetLength(1); h++)
                    {
                        if(freqmatrix[i,j] == freqmatrix[k,h])
                        {
                            counterSubmission++;
                        }
                    }
                }
                resultArray[placeNewArray,1] = counterSubmission;
                placeNewArray++;
            }
    }    
return resultArray;
}

void RemoveRepetition (int[,] resultfreqmatrix)
{
    for (int i = 0; i < resultfreqmatrix.GetLength(0); i++)
    {
        for (int k = i+1; k < resultfreqmatrix.GetLength(0); k++)
        {
            if (resultfreqmatrix[k,0]==resultfreqmatrix[i,0])
            {
                resultfreqmatrix[k,1] = (Math.Abs(resultfreqmatrix[k,1]))*(-1);
            }
        }
    Console.WriteLine($"Проверка {resultfreqmatrix[i,0]} {resultfreqmatrix[i,1]} ");   
    }
    for (int j = 0; j < resultfreqmatrix.GetLength(0); j++)
    {
        if(resultfreqmatrix[j,1]>0)
        {
            Console.WriteLine($"Число {resultfreqmatrix[j,0]} встречается {resultfreqmatrix[j,1]} раз");
        }
    }
}
FillTwoDimensiounalArray(matrix);
PrintTwoDimensionalArray(matrix);
PrintTwoDimensionalArray(FrequencyAnalisMatrix(matrix));
RemoveRepetition(FrequencyAnalisMatrix(matrix));
