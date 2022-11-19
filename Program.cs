using System;

// Console.WriteLine("Enter date");
// int number = Convert.ToInt32(Console.ReadLine());

//Напишите программу, которая на вход принимает число и выдает его квадрат,
// Console.WriteLine("Введите число, квадрат которого нужно найти: ");

// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;
// Console.WriteLine($"Квадрат {number} равен {result}");

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 * number2 == number1)
//{
//    Console.WriteLine($"число {number1} является квадратом {number2}");
//}
//else
//{
//    Console.WriteLine($"число {number1} не является квадратом {number2}");
//}

// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все числа в промежутке от -N до N.

// Console.WriteLine("Дорогой пользователь введи число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//    Console.Write(current + " ");
//    current++;
// }

/* Задача 1

// Напишите программу, которая на входе принимает два числа и выдаёт, 
// какое число больше, а какое меньше.

// a=5, b=7 -> max=7
// a=2, b=10 -> max=10

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"первое число {number1} больше второго числа {number2} ");
}
else
{
    Console.WriteLine($"первое число {number1} меньше второго числа {number2} ");
}

/* Задача 2 */

// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// if (max<number2)
// {
// max=number2;
// }
// if (max<number3)
// {
// max=number3;
// }
// Console.WriteLine($"максимальное число: {max}");

/* Задача 3 */

// Напишите программу, которая на вход принимаает число и выдает является ли число четным (делится ли оно на два без остатка)

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
//  Console.WriteLine($"число {number} - четное");
// else
//  Console.WriteLine($"число {number} - нечетное");

/* Задача 4 */

// Напишите программу, которая нв вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=n){
    if (i%2==0)
        Console.WriteLine($"число {i} - четное");
    i=i+1;
}






        









