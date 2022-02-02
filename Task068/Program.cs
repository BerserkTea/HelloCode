// 68. Показать натуральные числа от M до N, N и M заданы
int N = 35;
int M = 6;
void FromMToN (int firstnumber,int lastnumber)
{
    Console.Write($"{firstnumber} ");
    if (firstnumber!= lastnumber)
    FromMToN (firstnumber+1,lastnumber);
  
}
FromMToN(M,N);