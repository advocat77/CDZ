Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (max > number2)
{
   max = number1;
}
else
   if (number3 > max)
{
   max = number3;
}
Console.WriteLine($"Число {max} является максимальным");


