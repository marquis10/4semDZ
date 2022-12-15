Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()), res = A;
for (int i = 1;  i < B; i++)
{
    res = res * A;
}    
Console.WriteLine($"Число A в степени B = {res}");