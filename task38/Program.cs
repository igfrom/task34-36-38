double[] FillArray(int size)
{
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
}
return array;
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
Console.WriteLine (String.Join(", ", array));

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
        
    
  if (array[i] < min)
    {
         min = array[i];
    }
}
Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");