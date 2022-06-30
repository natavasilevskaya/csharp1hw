int number1;

Console.WriteLine("Imput number: ");
number1 = Convert.ToInt32(Console.ReadLine());

if (number1%2 == 0)
{
    Console.Write(number1 + " is an even number!");
}
else
{
    Console.Write(number1 + " is an odd number!");
}