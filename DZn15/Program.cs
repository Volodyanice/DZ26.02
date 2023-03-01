//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int dailyofWeek = Convert.ToInt32(Console.ReadLine());
if (dailyofWeek == 6 || dailyofWeek == 7)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");