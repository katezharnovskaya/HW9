//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Random rnd = new Random();
int n = rnd.Next(5, 30);
int m = rnd.Next(5, 30);
while (n >= m)
{
    m = rnd.Next(3, 10);
    n = rnd.Next(3, 10);
}
Console.WriteLine("Сумма от " + n + " до " + m + " :");

int Recursion(int n, int m)
{
    if (n == m + 1) return 0;
    else return n + Recursion(n + 1, m);
}
Console.WriteLine(Recursion(n, m));