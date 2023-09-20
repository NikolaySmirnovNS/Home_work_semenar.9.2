// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Program
{
    static void Main()
    {
        Console.WriteLine("Задайте значения M и N:");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(m, n);

        Console.WriteLine("Сумма натуральных элементов между  {0} и {1} равна {2}.", m, n, sum);
    }

    static int CalculateSum(int m, int n)
    {
        int sum = 0;

        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}