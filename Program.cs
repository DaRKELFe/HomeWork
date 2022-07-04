
//Первое задание
int num1, num2;

Console.WriteLine("input a number");

num1 = Convert.ToInt32(Console.ReadLine());

num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1); 
};
    
if (num2 > num1)
{
    Console.WriteLine(num2);
};

if (num1 == num2)
{   
    Console.WriteLine("они равны");     
};

//Второе задание
int num1, num2, num3;

Console.WriteLine("input a number");

num1 = Convert.ToInt32(Console.ReadLine());

num2 = Convert.ToInt32(Console.ReadLine());

num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)

{
    if (num1>num3)
         {
            Console.WriteLine(num1);
         };
};
    if (num2>num1)
    {
    if (num2>num3)
         {
            Console.WriteLine(num2);
         };
};
      if (num3>num1)
    {
    if (num3>num2)
         {
            Console.WriteLine(num3);
         };
};

      if (num1==num2)
    {
    if (num1==num3)
         {
            Console.WriteLine("vse ravno"+" "+num1);
         };
};

//Третье задание

int num1,current,n;

Console.WriteLine("input a number");
current=0;

num1 = Convert.ToInt32(Console.ReadLine());
n=num1;
if(num1>0)
{
while(current<=n)

{
   n = num1%2;
    current++;
};
}
if(num1<0)
{
while(current>=n)

{
   n = num1%2;
    current++;
};
}
if(n==0)
{
   Console.WriteLine("yes");

};

if(n>0)
{
    Console.WriteLine("no");

};

if(n<0)
{
    Console.WriteLine("no");

};

//четвертое задание

int num1,current;

Console.WriteLine("input a number");
current=0;
num1 = Convert.ToInt32(Console.ReadLine());
for (current=1; current<=num1; current++)
{
    
    if(current%2==0)
    {
     Console.WriteLine(current);
    };
      
};
