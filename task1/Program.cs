Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
   Console.WriteLine($"Число {number1} является максимальным ");
}
else
   Console.WriteLine($"Число {number2} является максимальным");



