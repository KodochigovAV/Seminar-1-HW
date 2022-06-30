// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter 1 => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);

Console.Write("Enter 2 => ");
string Letterdig2 = Console.ReadLine();
int B = int.Parse(Letterdig2);

if(A > B)
{
Console.WriteLine("Max " + A + " Min " + B);
}
else
{
Console.WriteLine("Max " + B + " Min " + A);
}