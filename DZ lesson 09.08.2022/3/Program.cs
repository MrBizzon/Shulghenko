// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

string[] week = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

if (number <= week.Length - 2) Console.WriteLine($"{week[number - 1]} является рабочим днем");
if (number > week.Length -2 && number <= week.Length) Console.WriteLine($"{week[number - 1]} - это выходной");
if (number > week.Length) Console.WriteLine("Не надо хулиганить");