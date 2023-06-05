// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
int[] digits = new int[5];
for (int i = 0; i < 5; i++)
{
    digits[i] = num % 10;
    num /= 10;
}

bool isPalindrome = true;
for (int i = 0, j = 4; i < 2; i++, j--)
{
    if (digits[i] != digits[j])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}