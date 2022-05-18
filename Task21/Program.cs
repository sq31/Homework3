/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки А в 3D пространстве:");
Console.Write("А: X=");
int AX = Convert.ToInt32(Console.ReadLine());
Console.Write("А: Y=");
int AY = Convert.ToInt32(Console.ReadLine());
Console.Write("А: Z=");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B в 3D пространстве:");
Console.Write("B: X=");
int BX = Convert.ToInt32(Console.ReadLine());
Console.Write("B: Y=");
int BY = Convert.ToInt32(Console.ReadLine());
Console.Write("B: Z=");
int BZ = Convert.ToInt32(Console.ReadLine());

int X = AX - BX;
int Y = AY - BY;
int Z = AZ - BZ;

Console.WriteLine($"Катет по стороне X={Math.Abs(X)}, Катет по стороне Y={Math.Abs(Y)}");
double resultXY = Math.Sqrt(X * X + Y * Y);

Console.WriteLine($"Расстояние между точками A({AX}:{AY}) и B({BX}:{BY}) равняется " + Math.Round(resultXY, 2));

double resultXYZ = Math.Sqrt(resultXY * resultXY + Z * Z);

Console.WriteLine($"Катет по стороне Z={Math.Abs(Z)}");
Console.WriteLine($"Расстояние между точками A({AX}:{AY}:{AZ}) и B({BX}:{BY}:{BZ}) равняется " + Math.Round(resultXYZ, 2));