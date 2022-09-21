Console.Clear();

Console.WriteLine("введите первое число: ");
string input = Console.ReadLine();
int number1 = int.Parse(input);

Console.WriteLine("введите второе число: ");
string input1 = Console.ReadLine();
int number2 = int.Parse(input1);

Console.WriteLine("введите третье число: ");
string input2 = Console.ReadLine();
int number3 = int.Parse(input2);

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"max= {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"max= {number2}");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"max= {number3}");
}
