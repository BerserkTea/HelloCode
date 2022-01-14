// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] somearray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 6, 10, 12, 15 };
int[] secondsomearray = new int[(somearray.Length)/2];
int fromBackCounter = somearray.Length - 1;

for (int i = 0; i < secondsomearray.Length; i++)
{
    secondsomearray[i] = somearray[i] * somearray[fromBackCounter];
    --fromBackCounter;
}
for (int j = 0; j < secondsomearray.Length; j++)
{
    Console.WriteLine(secondsomearray[j]);
}