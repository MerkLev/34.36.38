Console.Write("Введите размер массива: ");
int size= Convert.ToInt32(Console.ReadLine());
int Count=0;

    int [] Arr= new int [size];
    for (int i = 0; i < size; i++)
    {
        Arr [i] =  new Random().Next(100,999);
    }
    for (int i = 0; i < size; i++)
    {
        if (Arr[i]%2==0)
        {
            Count+=1;
        }
        
    }
Console.WriteLine($"Количество четных элементов в массиве :  {Count}");
Console.WriteLine($"[{String.Join(",", Arr )}]");