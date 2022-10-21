// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumb()
{
    int sum = 0;
    while (A > 0)
    {
        sum = sum +A%10;
        A=A/10;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumb(a));
