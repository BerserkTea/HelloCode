// 34. Написать программу замену элементов массива на противоположные
int[] somearray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

void SwitchArr(int[] oldarray)
{
    int length = oldarray.Length;
    int[] switchedArray = new int[length];
    int fromBack = length - 1;
    for (int i = 0; i < length; i++)
    {
        switchedArray[i] = oldarray[fromBack];
        --fromBack;
        Console.WriteLine(switchedArray[i]);
    }
}
void MinusNumbersArray(int[] oldestarray)
{
    int howlong = oldestarray.Length;
    for (int j = 0; j < howlong; j++)
    {
        oldestarray[j] = oldestarray[j] * (-1);
        Console.WriteLine(oldestarray[j]);
    }
}
// void PrintArrResult (int[] arrToPrint)
// {
//     for (int j = 0; j<arrToPrint.Length;j++)
//     {
//         Console.WriteLine(arrToPrint[j]);
//     }
// }
SwitchArr(somearray);
// PrintArrResult(somearray);
MinusNumbersArray(somearray);