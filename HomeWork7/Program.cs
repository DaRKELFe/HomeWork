/*int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for (int i= 0; i < rows; i++)
        for(int j = 0; j<columns; j++)
            newArray[i,j] = new Random().Next(-100, 100);    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i <array.GetLength(0); i++)
    {      
               for(int j = 0; j <array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
              
            Console.WriteLine();
    }
}

Console.Write("Input numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int n = Convert.ToInt32(Console.ReadLine());




int[,] array = CreateRandom2dArray(m,n);

Show2dArray(array);
*/
/*
int znach=0;
int znach2=0;
int coordinat2=0;
Console.Write("Coordinat: ");
int coordinat1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for (int i= 0; i < rows; i++)
        for(int j = 0; j<columns; j++)
            newArray[i,j] = new Random().Next(-100, 100);    
    return newArray;
}

void Show2dArray(int[,] array)
{
znach=coordinat1/m;
coordinat2=coordinat1/m-1;
znach2=coordinat1/znach-1;
    if(coordinat1>m*n)
    Console.WriteLine("F topku");

    else Console.WriteLine(array[coordinat2,znach2]);


    for(int i = 0; i <array.GetLength(0); i++)
    {    

       for(int j = 0; j <array.GetLength(1); j++)
       Console.Write(array[i,j] + " ");
       Console.WriteLine();

    }
    
}


int[,] array = CreateRandom2dArray(m,n);
Show2dArray(array);
*/
Console.Write("Input numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for (int i= 0; i < rows; i++)
        for(int j = 0; j<columns; j++)
            newArray[i,j] = new Random().Next(-10, 10);    
    return newArray;
}

void Show2dArray(int[,] array)
{
    double sred=0;
    double sum=0;
    for(int i = 0; i <array.GetLength(0); i++)
    {      

               for(int j = 0; j <array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
              
            Console.WriteLine();
           
            
    }
     for(int j = 0; j <array.GetLength(0); j++)
          { 
            for(int i = 0; i <array.GetLength(1); i++)
          sum = sum + array[i,j];
          sred = sum / n;  
   Console.Write("sredniye : " + sred + " ");
   }
}


int[,] array = CreateRandom2dArray(m,n);
Show2dArray(array);