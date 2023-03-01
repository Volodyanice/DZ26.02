// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int number = Convert.ToInt32(Console.ReadLine());
int thrdNumber = 0;
if (number>=100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    thrdNumber = number % 10;
    System.Console.WriteLine(thrdNumber);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}