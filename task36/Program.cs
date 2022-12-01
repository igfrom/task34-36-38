int[] FillArray(int size)
{
    int[] array = new int[size];
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-10,10);
}
return array;
}
Console.Write("Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(String.Join(", ", array));
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}
{
    Console.WriteLine($"Сумма нечетных индексов равна {sum}");
}