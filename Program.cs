Console.WriteLine("Введите первое число: ");
int num_X= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_Y = Convert.ToInt32(Console.ReadLine());

if (num_X > num_Y)
{
Console.WriteLine("Первое число " + num_X + " больше чем второе " + num_Y);
}
else
{
Console.WriteLine("Второе число " + num_Y + " больше чем первое " + num_X);
}