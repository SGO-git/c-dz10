﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Imput number");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (int i = 1; i <= N; i++)
{
    System.Console.Write(Math.Pow(i, 3) + ", ");
}
