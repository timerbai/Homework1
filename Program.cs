// Console.WriteLine("Input Number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine ($"Quad of {num} is {quad}");

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

// Задача 4
// Console.WriteLine("Input three digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 10;

// Console.WriteLine($"Last digit of {num} is {result}");

// Задача 3 
// Console.WriteLine("Input ferst number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;
// if (quad == num1)
// {
//     Console.WriteLine("Ferst number is quad of second number");
// }
// else
// {
//     Console.WriteLine("Ferst num is not quad of sec num");
// }

// Задача 2
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }

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