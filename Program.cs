// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите 1 число  по оси Х: ");
int x0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число  по оси Х: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 1 число  по оси Y: ");
int y0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число  по оси Y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 1 число  по оси Z: ");
int z0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число  по оси Z: ");
int z1 = int.Parse(Console.ReadLine()!);

double x= Math.Pow((x1-x0),2);
Console.Write($"Х = {x} ");
double y= Math.Pow((y1-y0),2);
Console.Write($"Y = {y} ");
double z= Math.Pow((z1-z0),2);
Console.Write($"Z = {z} ");
double res =Math.Sqrt(x+y+z);
//Console.Write($"длинна отрезка ровна {(Math.Round(res,2))} ");
Console.Write($"длинна отрезка ровна {res:f2} "); //тоже что и в предыдущем варианте

