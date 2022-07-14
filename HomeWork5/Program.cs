/*int[] CreateRandomArray(int size)
{
int[] newArray = new int[size];

for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(100, 999);    
    
    return newArray;

}


void ShowArray(int[] array)
{
    int b=0;
    for(int i = 0; i <array.Length; i++)
          
               Console.Write(array[i] + " " );
               for(int a = 0; a <array.Length; a++)
               if (array[a]%2 == 0)
               b=b+1;
               Console.Write("-> "+b);

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] array1 = CreateRandomArray(size);

ShowArray(array1);
*/

/*int[] CreateRandomArray(int size)
{
int[] newArray = new int[size];

for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(-99, 99);    
    
    return newArray;

}


void ShowArray(int[] array)
{
    int b=0;
    for(int i = 0; i <array.Length; i++)
          
               Console.Write(array[i] + " " );
               for(int a = 0; a <array.Length; a++)
               if (a%2 == 0)
               b=b+array[a];
               Console.Write("-> "+b);

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] array1 = CreateRandomArray(size);

ShowArray(array1);
*/

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
    int max=0;
    int min=1000000;
    int raz=0;
    for(int i = 0; i <array.Length; i++)
          
               Console.Write(array[i] + " " );
               for(int a = 0; a <array.Length; a++)
               if (array[a] > max)
               max=array[a];
               for(int g = 0; g <array.Length; g++)
               if (array[g] < min)
               min=array[g];
               raz=max-min;
               Console.Write("-> "+ raz );

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array2 = CreateArray(size);

ShowArray(array2);