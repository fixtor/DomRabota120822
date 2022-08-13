void Digits(int num)
{
    int i = 0;
    int count = 0;
    for (i = 1; i <= num; i++)
    {
        count = Convert.ToInt32(Math.Pow(i, 3));
        Console.WriteLine($"{i} ^ 3 = {count}");
    }
}

Console.Clear();
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
Digits(number);