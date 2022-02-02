// 69. Найти сумму элементов от M до N, N и M заданы

int N = 13;
int M = 12;
int SummFromMToN (int firstnumber,int lastnumber)
{
    if (firstnumber== lastnumber) return lastnumber;
    else return firstnumber += SummFromMToN(firstnumber+1,lastnumber);
}

int summary = SummFromMToN(M,N);
Console.WriteLine (summary);