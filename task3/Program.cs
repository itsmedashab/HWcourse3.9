// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m, n;
Console.Write($"Введите неотрицательное число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите неотрицательное число N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"{Accerman(m, n)}\n");

//----------------------
int Accerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (b == 0)
        return Accerman(a - 1, 1);
    else
        return Accerman(a - 1, Accerman(a, b - 1));
}