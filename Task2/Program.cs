Console.WriteLine("Imput number1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2>max) max = n2;
if (n3>max) max = n3;
Console.Write("Max number is " + max );