using System.Xml;
using LR7;

Matrix A = new();
Matrix B = new(1, 2, 3, 4);
Matrix C = new(new int[,] { {1, 0}, {1, 8} });
Matrix D = new(B);

Console.WriteLine($" {A.ToString()}, {B.ToString()}, {C.ToString()}, {D.ToString()}");
Console.WriteLine();

Console.WriteLine(C + B);
Console.WriteLine(C - B);
Console.WriteLine();

Console.WriteLine(++A);
Console.WriteLine(--A);
Console.WriteLine();

Console.WriteLine(B * 5);
Console.WriteLine(B / 2);
Console.WriteLine();

if (B == D)
    Console.WriteLine("B equals D");
if (B != A)
    Console.WriteLine("B not equals A");
Console.WriteLine();

if (A)
    Console.WriteLine("Determinant is not zero");
else
    Console.WriteLine("Determinant is zero");
if (B)
    Console.WriteLine("Determinant is not zero");
else
    Console.WriteLine("Determinant is zero");
Console.WriteLine();

Console.WriteLine($"Deteminant B is {(int)B}");
Console.WriteLine($"Matrix from 4 is {(Matrix)4}");
Console.WriteLine();