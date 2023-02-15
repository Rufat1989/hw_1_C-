Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);

if(x % 2 == 0)
{
    Console.Write("Да, число " + x + " четное");
}
else
{
    Console.Write("Нет,число " + x + " нечетное");
}