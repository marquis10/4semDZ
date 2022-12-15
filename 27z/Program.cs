Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), c = n, res = 0, temp = 0;
while (n > 0)
    {
        temp = n % 10;
        n /= 10;
        res = res + temp;
    }
Console.WriteLine($"Сумма цифр в числе {c} = {res}");