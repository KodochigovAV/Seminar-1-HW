// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter 1 => ");
string Letterdig1 = Console.ReadLine();
int A = int.Parse(Letterdig1);

Console.Write("Enter 2 => ");
string Letterdig2 = Console.ReadLine();
int B = int.Parse(Letterdig2);

Console.Write("Enter 3 => ");
string Letterdig3 = Console.ReadLine();
int C = int.Parse(Letterdig3);

int MAX = A;

if(A > MAX) MAX = A;
if(B > MAX) MAX = B;
if(C > MAX) MAX = C;

Console.WriteLine("Max " + MAX);