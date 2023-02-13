// Домашняя работа Семинара №1

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"Maximal number is {num1}");
// }
// else
// {
//     Console.WriteLine($"Maximal number is {num2}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input thirt number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.WriteLine($"Maximal number is {max}");

// Задание 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
// Console.WriteLine("Input Number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

// Console.WriteLine("Input Number");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 0;

// while (current <= num)
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }