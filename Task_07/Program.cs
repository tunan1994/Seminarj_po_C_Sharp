﻿// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Чтобы определить последнюю цифру трёхзначного числа: ");

Console.WriteLine("Введите целое трехзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());

int result = num1 % 10;

Console.WriteLine("Последняя цифра трёхзначного числа: " + result);