// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation (int A, int B)
{
    int count = 1;
    for(int i = 1; i <= B; i++)
    {
        count *= A;
    }
    return(count);
}

int A = ReadInt("Введите число A:");
int B = ReadInt("Введите число B:");
int count = Exponentiation(A, B);
Console.WriteLine($"Число {A} в степени {B} = {count}");
