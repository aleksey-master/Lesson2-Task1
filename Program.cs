//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
};
//
//int numberA = Prompt("Введите трехзначное число: ");
//int numberB = numberA / 10 % 10; 
//System.Console.WriteLine(numberB);

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(number);
Console.WriteLine("Вторая цифра этого числа: " + array[1]);
