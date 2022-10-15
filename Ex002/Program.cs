/*  Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string NumberA = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string NumberB = Console.ReadLine();
int NumberInt1 = int.Parse(NumberA);
int NumberInt2 = int.Parse(NumberB);

if (NumberInt1 > NumberInt2)
{
    Console.WriteLine($"Большее число: {NumberInt1} ");
    Console.WriteLine($"Меньшее число: {NumberInt2} ");
}
else
{
    Console.WriteLine($"Большее число: {NumberInt2} ");
    Console.WriteLine($"Меньшее число: {NumberInt1} ");
}
