Console.Clear();
Console.WriteLine("Введите любое число больше 10:");
int number = Convert.ToInt32(Console.ReadLine());
int fistDigit = 0;
int lastDigit = 0;
if (number < 10)
    Console.WriteLine($"Вы ввели неверное число {number} < 10");

else
{
    while (number != fistDigit)
        lastDigit = number % 10;
    if (lastDigit != fistDigit)
        Console.WriteLine($"Число {number} не палиндром");
    else
        Console.WriteLine($"Число {number} палиндром");
}