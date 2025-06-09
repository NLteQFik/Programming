using Task2.Services;

double c = 0, d = 0, k = 1, z = 1;
Function f = new Function(c, d, k, z);
Console.WriteLine($"Value of function: {f.ComputeFunction()} and branch: {f.GetBranch()}");
