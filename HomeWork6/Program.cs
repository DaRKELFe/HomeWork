/* int[] CreateArray(int size)
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
    int sramota = 0;
    for(int i = 0; i <array.Length; i++)
          
               Console.Write(array[i] + " " );
               for(int a = 0; a <array.Length; a++)
               if (array[a] < 0)
               sramota=sramota+1;
               Console.Write("-> " + sramota);
              
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array2 = CreateArray(size);

ShowArray(array2);
*/
double[] CreateArray(int size)
{
    double [] newArray = new double [4];

    Console.WriteLine("Enter b1, k1, b2, k2");
    for (int i= 0; i < 4; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(double [] array)
{
    double sramota = (array[2]-array[0])/(array[1]-array[3]);
    double sramota2 = array[1]* sramota + array[0];
              
    Console.WriteLine(sramota + " : " + sramota2 );
}

double[] array2 = CreateArray(4);

ShowArray(array2);