void CutNumber()
{

    Console.WriteLine("Press imput: ");
    var s = Console.ReadLine();
    int i = 0;
    int count = s.Length;
    int sum = 0;
    while (i < count)
    {
        sum += s[i++] - 48;
    }
    Console.WriteLine(sum);
 
}

CutNumber();

/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here");
    for (int i= 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i <array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] array2 = CreateArray(size);

ShowArray(array2);
*/