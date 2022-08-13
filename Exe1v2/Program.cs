int numberLenght(int num) // Проверка количества символов в числах
{
    int i = 0;
    for (i = 0; num > 0; i++)
        num = num / 10;
    return i;
}

int getBackDigit(int number)
{
    int counter = 0;
    while (number > 0)
    {
        counter = counter * 10 + number % 10;
        number /= 10;
    }
    return counter;
}

Console.WriteLine("Введите 1-е число больше 10:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Перевертыш {getBackDigit(number)}");
Console.WriteLine("Введите 2-е число больше 10:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (numberLenght(number)==numberLenght(number2))
{
    if (getBackDigit(number) == number2)
    Console.Writeline($"Введеное вами 1-е число {number} Является палиндромом числа 2 {number2}");
    else
    Console.Writeline($"Введеное вами 1-е число {number} Не является палиндромом числа 2 {number2}");
}
else 
Console.Writeline($"Введеное вами 1-е число {number} отлично по длине от {number2}");