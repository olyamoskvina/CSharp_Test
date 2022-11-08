// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// void GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     Console.WriteLine($"Cумма цифр от 1 до введенного числа: {sum}");

// }

// Console.Clear();

// // GetSumNums(5);

// Console.WriteLine("Введите число: ");

// int sum1 = Convert.ToInt32(Console.ReadLine());
// GetSumNums(sum1);


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Clear();

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int sum = GetCountNums(num);
// Console.WriteLine($"Количество цифр = {sum}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


// int GetCountNums(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// void GetMultNums(int number)
// {
//     int mult = 1;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         mult *= i;
//     }
//     Console.WriteLine($"произведение цифр от 1 до введенного числа: {mult}");

// }
// Console.Clear();

// GetMultNums(5);

// // Console.WriteLine("Введите число: ");

// // int mult1 = Convert.ToInt32(Console.ReadLine());
// // GetMultNums(mult1);



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = GetBinaryArray(8);
// Console.WriteLine($" [ {String.Join(",", array)} ] ");


// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }

//     return result;
// }

