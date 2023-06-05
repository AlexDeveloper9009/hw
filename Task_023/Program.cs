// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"{i} в кубе = {cube}");
}