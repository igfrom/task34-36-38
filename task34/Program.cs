int[] FillArray (int size)
{
    int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
return array;
}
Console.Write("Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        count++;
    }
    }
    if(count>0)
    {
        Console.WriteLine($"В массиве найдено {count} четных чисел");
    }
    else
    {
    Console.WriteLine("Четных чисел не найдено");
    }
