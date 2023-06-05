// На столе лежат n монеток. Некоторые из них лежат вверх решкой,
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
// чтобы все монетки были повернуты вверх одной и той же стороной.
// 1-Решка
// 0-Орел 
Console.Write("Введите количество монет: ");
int n = Int32.Parse(Console.ReadLine());

Console.Write("Введите состояние монет (H - решка, T - герб Через пробел): ");
string coins = Console.ReadLine();

int headCount = 0;
for (int i = 0; i < coins.Length; i++)
{
    if (coins[i] == 'H')
    {
        headCount++;
    }
}

int flips = Math.Min(headCount, n - headCount);

Console.WriteLine($"Нужно перевернуть {flips} монет(ы).");