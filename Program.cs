// Для проверки решений раскомментировать необходимый участок кода

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// System.Console.WriteLine("Напишите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     System.Console.WriteLine("Кратно");
// }
// else{
//     System.Console.WriteLine("Не кратно");
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите Х");
// double numX = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите Y");
// double numY = Convert.ToDouble(Console.ReadLine());
// if (numX > 0 && numY > 0)
// {
//     Console.WriteLine("1 координатная четверть");
// }
// else if (numX < 0 && numY > 0)
// {
//     Console.WriteLine("2 координатная четверть");
// }
// else if (numX < 0 && numY < 0)
// {
//     Console.WriteLine("3 координатная четверть");
// }
// else if (numX > 0 && numY < 0)
// {
//     Console.WriteLine("4 координатная четверть");
// }
// else
// {
//     Console.WriteLine("Точка находится на одной из осей");
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// System.Console.WriteLine("Напишите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10 && number <= 99)
// {
//     int FitstNum = number / 10;
//     int SecondNum = number % 10;
//     if (FitstNum >= SecondNum){
//         System.Console.WriteLine(FitstNum);
//     }
//     else{
//         System.Console.WriteLine(SecondNum);
//     }

// }
// else
// {
//     System.Console.WriteLine("Введите другое число");
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// System.Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0)
// {
//     string numberString = number.ToString();
//     for (int i = 0; i < numberString.Length; i++)
//     {
//         if (i < numberString.Length - 1)
//         {
//             Console.WrFte(numberString[i] + ", ");
//         }
//         else
//         {
//             Console.Write(numberString[i]);
//         }
//     }
// }
// else
// {
//     System.Console.WriteLine("Введите натуральное число");
// }

// Реализация с обратным выводом чисел
System.Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    string numberString = number.ToString();
    for (int i = numberString.Length-1; i > -1; i--)
    {
        if (i > 0)
        {
            Console.Write(numberString[i] + ", ");
        }
        else
        {
            Console.Write(numberString[i]);
        }
    }
}
else
{
    System.Console.WriteLine("Введите натуральное число");
}