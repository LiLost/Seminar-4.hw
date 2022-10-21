﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeOfNumb(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(DegreeOfNumb(a,b));
