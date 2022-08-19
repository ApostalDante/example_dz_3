/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/* - решение - */

Console.Clear();
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - палиндром.");
    }
    else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else
    Console.WriteLine($"Вы ввели не пятизначное число");


/*-------------------------------------------------------*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/* - решение - */

Console.Clear();

int InputCoordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

int x1 = InputCoordinate("x", "A");
int y1 = InputCoordinate("y", "A");
int z1 = InputCoordinate("z", "A");
int x2 = InputCoordinate("x", "B");
int y2 = InputCoordinate("y", "B");
int z2 = InputCoordinate("z", "B");


double DistanceCalculation(double x1, double x2,
                    double y1, double y2,
                    double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double lengthDistance = Math.Round(DistanceCalculation(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {lengthDistance}");

/*-------------------------------------------------------*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/* - решение - */

Console.Clear();
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int counter = 0;
    int length = cube.Length;
    while (counter < length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while (index < count)
    {
        Console.WriteLine(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArry(arry);
