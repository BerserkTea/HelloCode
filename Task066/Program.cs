//66. Показать натуральные числа от 1 до N, N задано 

int N = 25;
int counter = 1;
void FromOneToN (int lastnumber, int firstnumber)
{
    Console.Write($"{firstnumber} ");
    if (firstnumber!= lastnumber)
    FromOneToN (lastnumber,firstnumber+1);
  
}
FromOneToN(N,counter);
