// 14. Найти третью цифру числа или сообщить, что её нет

// string chislo = Console.ReadLine();
// char[] ch = new char[chislo.Length]; 
//  for (int i = 0; i < chislo.Length; i++) { 
//             ch[i] = chislo[i]; 
//            Console.WriteLine(ch[i]);
//         }

int a = 6534;
string chislo = Convert.ToString(a);
char[] numbarr = new char[chislo.Length];
for (int index = 0; index < chislo.Length; index++)
{
    numbarr[index] = chislo[index];
}
if (numbarr[2] != 0)
{
    Console.WriteLine(numbarr[2]);    // как уточнить существует ли эллемент массива?
}
else
{
    Console.WriteLine("А нет её, всё-всё нет её.");
}