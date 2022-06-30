// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Enter 1 => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);

int Even = A % 2;

if (Even == 0)
{
Console.Write("Chetnoe");
}
else
{
Console.Write("Nechetnoe");
}