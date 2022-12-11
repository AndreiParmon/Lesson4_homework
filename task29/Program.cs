// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем.

int[] array = new int[8];
Console.WriteLine("Введите элементы массива через Enter: ");
for (int i = 0; i <= 7; i++)
{
    array[i] += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Введенный массив: {string.Join(", ", array)}.");