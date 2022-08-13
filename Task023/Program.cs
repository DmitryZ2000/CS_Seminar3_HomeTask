void PowerN3(int num)
{
    int index = 1;
    while (index < num)
    {
        Console.Write($"{Math.Pow(index, 3)}, ");
        index++;
    }
    Console.Write($"{Math.Pow(index, 3)}. ");
}

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PowerN3(num);
