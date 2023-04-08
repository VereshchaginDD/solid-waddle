Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m,n;
Console.Write("Введите значение M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите значение N: ");
int.TryParse(Console.ReadLine()!, out n);

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
