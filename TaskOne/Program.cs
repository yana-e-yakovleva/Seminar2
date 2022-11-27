Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

int First = number / 100;
int Second = (number - First*100)/10;

Console.WriteLine($"Вторым числом является {Second}");


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.