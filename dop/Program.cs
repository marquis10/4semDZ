Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число K: ");
int k = Convert.ToInt32(Console.ReadLine()), temp1 = 0, temp2 = 0;
if (k > 0)
{
    for (int s = 0; s < k; s++)
    {
        temp1 = array[0];
        array[0] = array[n-1];
        array[n-1] = temp1;
        for (int n1 = 1; n1 < n - 1; n1++)
        {
            temp2 = array[n - n1];
            array[n - n1] = array[n - (n1 + 1)];
            array[n - (n1 + 1)] = temp2;
        }    
    }
}
else
    {
        for (int s = 0; s > k; s--)
        {
            temp1 = array[0];
            array[0] = array[1];
            array[1] = temp1;
            for (int n1 = 1; n1 < n - 1; n1++)
            {
                temp2 = array[n1];
                array[n1] = array[n1 + 1];
                array[n1 + 1] = temp2;
            }    
        }
    }
Console.WriteLine($"Массив array: [{string.Join(", ", array)}]");