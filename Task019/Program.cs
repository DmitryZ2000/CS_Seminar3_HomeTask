void check_polindrom(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        Console.WriteLine($"Число {number} является полиндромом");
    else    
        Console.WriteLine($"Число {number} НЕ является полиндромом");
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10000 == 0 || number / 100000 > 0)
{
    Console.Write("Вы вели не пятизначное число");
}
else 
    check_polindrom(number);