﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"Число {num1} КРАТНО 7 и 23");
else Console.WriteLine($"Число {num1} НЕ кратно 7 и 23");