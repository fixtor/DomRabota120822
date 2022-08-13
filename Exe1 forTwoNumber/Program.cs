int numberLenght(int num) // Проверка количества символов в числах
{
    int i = 0;
    for (i = 0; num > 0; i++)
        num = num / 10;
    return i;
}

int getBackDigit(int num) // Игра переверни число
{
    int counter = 0;
    while (num > 0)
    {
        counter = counter * 10 + num % 10;
        num /= 10;
    }
    return counter;
}

Console.WriteLine("Введите 1-е число больше 10:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число больше 10:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (numberLenght(number) == numberLenght(number2)) //Проверяем совпадают ли по длине числа
{
    if (getBackDigit(number) == number2) // Cравниваем перевернутое число с заданным палиндром
        Console.WriteLine($"Введеное вами 1 число {number} Является палиндромом {number2}");
    else
        Console.WriteLine($"Введеное вами 1 число {number} Не является палиндромом {number2}!!!");
}
else
    Console.WriteLine($"Введеное вами 1 число {number} отлично по длине от {number2}");