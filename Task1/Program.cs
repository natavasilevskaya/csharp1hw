Console.WriteLine("Imput number1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput number2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
int min = n2;

if (n2>max) 
{
    max = n2;
    min = n1;
}

Console.WriteLine("Max number is " + max);
Console.WriteLine("Min number is " + min);