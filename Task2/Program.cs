//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
int a1 = 2, b1 = 3, c1 = 7, a2 = 44, b2 = 5, c2=78, a3 = 22, b3 = 3, c3=9;
string choice = "да";
Console.Write("Напишите да, если хотите вводить числа для сравнения сами: ");

string answer = Console.ReadLine().ToLower();

if (answer == choice)
{
    Console.Write("Введите первое целое число для сравнения: ");
    int aUserNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите отличное от первого целое число для сравнения: ");
    int bUserNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите отличное от первых 2х целое число для сравнения: ");
    int cUserNum = Convert.ToInt32(Console.ReadLine());
    int maxNum = aUserNum;
    if (bUserNum > maxNum) maxNum = bUserNum;
    if (cUserNum > maxNum) maxNum = cUserNum;

    Console.WriteLine($"Для aUserNum = {aUserNum}, bUserNum = {bUserNum} и cUserNum = {cUserNum} max = {maxNum}");}
else 
{
    int max = a1;
    if (max < b1)  max = b1;
    if (max < c1)  max = c1;
    Console.WriteLine($"Для a1 = {a1}, b1 = {b1} и с1 = {c1} max = {max}");

    max = a2;
    if (max < b2) max = b2;
    if (max < c2) max = c2; 
    Console.WriteLine($"Для a2 = {a2} и b1 = {b2} и с2 = {c2} max = {max}");

    max = a3;
    if (max < b3) max = b3;
    if (max < c3) max = c3; 
    Console.WriteLine($"Для a3 = {a3} и b3 = {b3} и с3 = {c3}  max = {max}");
}