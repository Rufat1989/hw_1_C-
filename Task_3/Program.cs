Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int x = 2;

while(x <= n)
{
    Console.Write(x);

    if(x < n-1)
    {
        Console.Write(",");
    }
    x = x + 2;
}
