// программа принимает на вход число N, а на выходе показывает все четные числа от 1 до N

int num;

Console.Write("Input your number: ");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i<=num; i++) 
{
    if(i%2 == 0) 
    {
        Console.Write("{0} ", i);
    }
}
