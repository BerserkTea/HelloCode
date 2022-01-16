// 43. Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Ведите десятичное число для преобразования его в двоичное");
int Number = Convert.ToInt32(Console.ReadLine());

void ConvertToBinary(int decimalNumber)
{
    int counter = 0;
    int arrLenght = decimalNumber;
    while (arrLenght >= 1)
    {
        arrLenght = arrLenght / 2;
        counter++;
    }
    int[] arrayBinaryNumber = new int[counter];
    int dividend = decimalNumber;
    int fromBackCounter = arrayBinaryNumber.Length - 1;
    while (dividend >= 1)
    {
        arrayBinaryNumber[fromBackCounter] = dividend % 2;
        dividend = dividend / 2;
        --fromBackCounter;
    }
    //arrayBinaryNumber[0]=dividend;
   
    for (int i = 0; i < arrayBinaryNumber.Length; i++)
    {
        Console.Write(arrayBinaryNumber[i]);
    }
}
ConvertToBinary(Number);

