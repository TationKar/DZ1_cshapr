//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();
int a1 = 5, b1 = 7, a2 = 2, b2 = 10, a3 = -9, b3 = -3;
string choice = "да";
Console.Write("Напишите да, если хотите вводить числа для сравнения сами: ");

string answer = Console.ReadLine().ToLower();

if (answer == choice)
{
    Console.Write("Введите первое целое число для сравнения: ");
    int aUserNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите отличное от первого целое число для сравнения: ");
    int bUserNum = Convert.ToInt32(Console.ReadLine());
    if (aUserNum > bUserNum)
    {Console.WriteLine($"Для aUserNum = {aUserNum} и bUserNum = {bUserNum} max = {aUserNum}");}
    else
    {Console.WriteLine($"Для aUserNum = {aUserNum} и bUserNum = {bUserNum} max = {bUserNum}");}
}
else 
{
    int max = a1;
    if (a1 < b1) { max = b1; } else { max = a1;}
    Console.WriteLine($"Для a1 = {a1} и b1 = {b1} max = {max}");

    if (a2 < b2) { max = b2; } else { max = a2;}
    Console.WriteLine($"Для a2 = {a2} и b1 = {b2} max = {max}");

    if (a3 < b3) { max = b3; } else { max = a3;}
    Console.WriteLine($"Для a3 = {a3} и b3 = {b3} max = {max}");
}