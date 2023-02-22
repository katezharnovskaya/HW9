//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());

int A(int n, int m)
{
    if(n==0) return m+1;
    else if(m==0 && n!=0) return A(n-1,1);
    else 
    return A(n-1,A(n,m-1));
}
Console.WriteLine("Результат:");
Console.WriteLine(A(n, m));