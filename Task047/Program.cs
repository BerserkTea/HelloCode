// 47. Написать программу копирования массива
int[] someArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

int[] copyArryMethod(int[] anotherarray)
{
    int[] copyArray = new int[anotherarray.Length];
    for (int i = 0; i < anotherarray.Length; i++)
    {
        copyArray[i] = anotherarray[i];
    }
    return copyArray;
}
void printArray(int[] whatToPrint)
{
    for (int i = 0; i < whatToPrint.Length; i++)
    {
        Console.Write($"{whatToPrint[i]} ");
    }
}
printArray(copyArryMethod(someArray));