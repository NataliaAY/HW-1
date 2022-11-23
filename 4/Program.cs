Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int i=0;
Console.Write($"чётные числа от 1 до {number}:");
while (i <number)
{
i+=1;
if(i %2==0)
{
Console.WriteLine($"{i}");  
}
}


         
