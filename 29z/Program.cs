Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()), j = 0;
int [] array = new int [n];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив array: [{string.Join(", ", array)}]");