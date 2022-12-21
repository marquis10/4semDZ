int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int k = Convert.ToInt32(Console.ReadLine());
k %= n; // нужен для того, чтобы убрать лишние операции, вместе 103, будет 3 прохода
int [] result = new int[n];
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = numbers[n - k + i];
    for (int i = 0; i < n - k; i++)
        result[k + i] = numbers[i];
}
else
{
    k = -k; // k = (1-) * k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = numbers[i];
    for (int i = 0; i < n - k; i++)
        result[i] = numbers[k + i];  
}
Console.WriteLine(string.Join(" ", result));