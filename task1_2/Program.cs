// Задача N°11. Работа в группах
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// • 456 -> 46
// •
// 782 -> 72
// • 918 -> 98
// вывести результат через resultat

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ваше случайное число: {number}");
int digit  = number/100;
int digit3 = number %10;

int result = digit*10 + digit3;
Console.Write($"ваше число {result}");