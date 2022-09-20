Console.Write("Введите размер массива: ");
int size= Convert.ToInt32(Console.ReadLine());
int sum=0;

    int [] Arr= new int [size];
    for (int i = 0; i < size; i++)
    {
        Arr [i] =  new Random().Next(-10,10);
    }
    for (int i = 1; i < size; i=i+2)
    {
        sum=sum+Arr[i];
    }

Console.WriteLine($"[{String.Join(",", Arr )}]");
Console.WriteLine($"Сумма нечетных элементов в массиве:  {sum}");