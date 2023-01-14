// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int size = 3;
int count = 1;
int max = number1;
while (count < size)
{count = count + 1;
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
    if (max < number2)
    {
    max = number2;
    };
};
Console.WriteLine(max); 