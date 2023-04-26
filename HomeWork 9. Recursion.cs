// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*

Console.WriteLine("Input digit > 1: ");
int number = int.Parse(Console.ReadLine());
void Numbers(int nums)
{
    if (nums < 0) Console.Write($"{nums} not natural number");
    if (nums == 0) return;
    Console.Write("{0, 10}", nums);
    Numbers(nums - 1);
}
Numbers(number);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Input digit M: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Input digit N: ");
int number2 = int.Parse(Console.ReadLine());

void SumNums(int number1, int number2, int sum)
{
    if (number1 > number2)
    {
        Console.WriteLine($"Sum between M & N: {sum}");
        return;
    }
    sum = sum + (number1++);
    SumNums(number1, number2, sum);
}
SumNums(number1, number2, 0);

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Input digit M: ");
int Levi = int.Parse(Console.ReadLine());

Console.Write("Input digit N: ");
int Mikasa = int.Parse(Console.ReadLine());

int TheAkermans(int Levi, int Mikasa)
{
    if (Levi == 0) return Mikasa + 1;
    if (Levi != 0 && Mikasa == 0) return TheAkermans(Levi - 1, 1);
    if (Levi > 0 && Mikasa > 0) return TheAkermans(Levi - 1, TheAkermans(Levi, Mikasa - 1));
    return TheAkermans(Levi, Mikasa);
}

Console.WriteLine($"Akkermans for digits A({Levi},{Mikasa}) = {TheAkermans(Levi, Mikasa)}");