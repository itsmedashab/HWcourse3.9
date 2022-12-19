// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int n;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

PrintNumbers(n, 1);
Console.Write($"\n");

//---------------------------------------
void PrintNumbers(int last, int first)
{
    if (last <= first)
    {
        Console.Write($"{last}");
    }
    else
    {
        Console.Write($"{last} ");
        PrintNumbers(last - 1, first);
    }
}