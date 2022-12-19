// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int maxNumber = numberA;

if (numberB > maxNumber)
{
maxNumber = numberB;
}

if (numberC > maxNumber)
{
maxNumber = numberC;
}

Console.WriteLine("Максимальное число =  " + maxNumber);