Console.Write("Введите размер массива: ");
int size= Convert.ToInt32(Console.ReadLine());
    double [] Arr= new double [size];
    for (int i = 0; i < size; i++)
    {
        Arr [i] =  new Random().NextDouble()*100;
    }
    double Max=Arr[0];
    double Min=Arr[0];
    for (int i = 0; i <= size-2; i++)
    {
        if(Arr[i]<Arr[i+1])
        {
            Max= Arr[i+1];
        }
        else
        {
            Min=Arr[i+1];
        }
    }
    double result=Max-Min;

Console.WriteLine($"[{String.Join(",", Arr )}]");
Console.WriteLine($" min={Min}, max={Max}");
Console.WriteLine($" Max-Min= {result}");

