/*void Number()
{
    Console.WriteLine("press push a button");
    int number = Convert.ToInt32(Console.ReadLine());
    int oldValue = number;
      int newValue = 0;
     while (number > 0)
     {
        int dig = number % 10;
         newValue = newValue * 10 + dig;
         number = number / 10;
    }
    if (newValue == oldValue)
      Console.WriteLine("Palindrom");
    else
    Console.WriteLine("Not Palindrom");
     Console.Write("press push alt + F4");
     Console.ReadKey();
}

Number();

*/

Console.Write("Press start");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int length = cube.Length;
  for (int counter = 0; counter <  length; counter++)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  
  for(int index = 0;index < count;index++)
  {
    Console.Write(coll[index]+ " ");
    
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);