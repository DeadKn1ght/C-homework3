// Задача 23:Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void Cubes(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    Console.WriteLine("Cubes of number N are : ");
    while (count <= number)
    {
        int cube = count * count * count;
        Console.WriteLine(cube);
        count++;
    }
}
Cubes("Input number N : ");