/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int num)
{
    int twoNumber = num%100;
    int secondNumber = twoNumber/10;
    return secondNumber;
}

if (number/100<10)
{
    if (number/100 > 0.99)
    {
        int result = SecondNumber(number);
        Console.WriteLine($"Вторая цифра введеного числа {number} -> {result}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод.");
}
