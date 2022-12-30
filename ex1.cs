// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Num(int a)
{
    if(a==1) return 1;
    System.Console.Write($"{a} ");
    return Num(a-1);
}

System.Console.WriteLine("Введите число");
int s = Convert.ToInt32(Console.ReadLine());
int x = Num(s);

System.Console.WriteLine(x);