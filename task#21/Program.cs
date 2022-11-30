// Задача 21:Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return result;
}


int x1 = DataEntryXY("Input x1 : ");
int y1 = DataEntryXY("Input y1 : ");
int z1 = DataEntryXY("Input z1 : ");

int x2 = DataEntryXY("Input x2 : ");
int y2 = DataEntryXY("Input y2 : ");
int z2 = DataEntryXY("Input z2 : ");

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Distanxe beetween dots :" + result);