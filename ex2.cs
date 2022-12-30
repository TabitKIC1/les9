// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int a, int b, int z)
{
int res = z;
if(a==b)
{
    return 0;
}

else
{
 a++;
 res = a +Sum(a,b,z);
 return res;   
}
}

       



System.Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int f = Convert.ToInt32(Console.ReadLine());


int summ = Sum(x,f,0);

System.Console.WriteLine(summ);