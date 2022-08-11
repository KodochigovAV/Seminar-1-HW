// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Enter => ");
string Letterdig1 = Console.ReadLine();
double A = double.Parse(Letterdig1);

double B = 2;

while(B <= A)
{
    Console.Write($"{B}, ");
        B = B + 2;
}
