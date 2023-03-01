// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber =( number % 100 )/ 10;
System.Console.WriteLine(secondNumber);