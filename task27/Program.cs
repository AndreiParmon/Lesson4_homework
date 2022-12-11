// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumOfDigits (int number)
{
    int sum = 0;
    number = Math.Abs(number);
    for(int i = 0; number != 0; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return(sum);
}
int n = ReadInt("Введите число:");
int sum = SumOfDigits(n);
Console.WriteLine($"Сумма цифр числа {n} = {sum}");
