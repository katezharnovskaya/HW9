//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Random rnd = new Random();
int n = rnd.Next(5, 30);

string Recursion(int n)
{
    if (n <=0) return "";
    else return Recursion(n-1)+" "+n;
}
Console.WriteLine(Recursion(n));
