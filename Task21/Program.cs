/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координаты точки А: X=");
int AX = Convert.ToInt32(Console.Read());
Console.Write(", Y=");
int AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: X=");
int BX = Convert.ToInt32(Console.Read());
Console.Write(", Y=");
int BY = Convert.ToInt32(Console.ReadLine());

int X = AX - BX;
int Y = AY - BY;
double resultXY = Math.Sqrt(X * X + Y * Y);

Console.WriteLine($"Расстояние между точками A({AX}:{AY}) и B({BX}:{BY}) равняется " + Math.Round(resultXY, 2));