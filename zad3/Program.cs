// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool PalidromDaNet(int n)
{
    int r=0;
    int nn=n;
    while (n>0)
    {
        r=r*10+n%10;
        n=n/10;
    }
    return r==nn;
}
Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (PalidromDaNet(n))
{
    Console.WriteLine($"{n} -> да");
}
else
{
    Console.WriteLine($"{n} -> нет");
}   
    
