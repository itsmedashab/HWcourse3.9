// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m, n;
Console.Write($"Введите M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"{PrintNumbers(m, n)}\n");

int sum = 0;
SumNumbers(m, n);
Console.Write($"Cумма элементов в промежутке от M до N = {sum}\n");

//---------------------------------------
string PrintNumbers(int first, int last)
{
    if (first >= last) 
        return last.ToString();
    else
        return $"{first} {PrintNumbers(first + 1, last)}";
}

//---------------------------------------
int SumNumbers(int first, int last)
{
    if (first > last) 
        return sum;
    else
        return sum += first + SumNumbers(first + 1, last);
}