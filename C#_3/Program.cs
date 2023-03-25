/*Задача 3. Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).

int a = 5;
int ost = 5 % 2;
int ost1 = 4 % 2;
4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 1)
{
    Console.WriteLine("Число" + n + "является - нечётным");
}else
{
    Console.WriteLine("Число" + n + "является - чётным");
}