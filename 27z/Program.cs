Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), res = 0, temp = 0;
while (n > 0)
    {
        temp = n % 10;
        n /= n;
        res = res + temp;
    }
Console.WriteLine($"Сумма цифр в числе {n} = {res}");