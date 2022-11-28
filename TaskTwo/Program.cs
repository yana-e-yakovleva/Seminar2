Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number <= 99)
    Console.WriteLine("Третьего числа нет");

while (number >= 100)
{
    number = number / 10;
    
}
  number = number % 10; 
    Console.WriteLine($"Третье число {number}");



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]



