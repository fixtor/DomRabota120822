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
{
    if (getBackDigit(number) == number) // Cравниваем перевернутое число с заданным палиндромом
        Console.WriteLine($"Введеное вами 1 число {number} Является палиндромом {getBackDigit(number)}");
    else
        Console.WriteLine($"Введеное вами 1 число {number} Не является палиндромом {getBackDigit(number)}!!!");
}
