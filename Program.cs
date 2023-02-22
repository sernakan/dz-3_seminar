using System.ComponentModel.DataAnnotations;
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.4212 -> нет
//14212 -> нет
//12821 -> да
//23432 -> да1

Console.WriteLine("Введите пятизначное число");

int Number = Convert.ToInt32(Console.ReadLine());
int Number1 = Number;
string Num = Convert.ToString(Number1);
int a = (Number / 10000) % 10;
int b = (Number / 1000) % 10;
int c = (Number / 100) % 10;
int d = (Number / 10) % 10;
int e = (Number / 1) % 10;

if (a == e && b == d)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else if (a != e && b != d && Num.Length < 6)
{
    Console.WriteLine("Введенное число не является палиндромом");
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}