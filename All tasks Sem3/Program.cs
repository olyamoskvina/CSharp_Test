// // 17 /* Напишите программу, которая принимает на вход координаты точки (X и Y), 
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// */

// int GetQuarterFromCoordinate(int userX, int userY)
// {
//     int quarter = 0;
//     if (userX > 0 && userY > 0)
//     {
//         quarter = 1;
//     }
//     else if (userX < 0 && userY > 0)
//     {
//         quarter = 2;
//     }
//     else if (userX < 0 && userY < 0)
//     {
//         quarter = 3;
//     }
//     else if (userX > 0 && userY < 0)
//     {
//         quarter = 4;
//     }
//     return quarter;
// }

// // Console.WriteLine("Введите координаты Х");
// // int userX = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите координаты Y");
// // int userY = Convert.ToInt32(Console.ReadLine());

// // int quarter = GetQuarterFromCoordinate(userX,userY);
// // if (quarter != 0)
// // {
// //     Console.WriteLine($"точка с коорддинатами {userX} и {userY} анходится в {quarter} четверти");
// // }
// // else Console.WriteLine($"точка с коорддинатами {userX} и {userY} анходится на одной из осей");



// / Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void GetCoordanatesFromQuarter(int quarter)
// {
//     if (quarter == 1)
//     {
//         Console.WriteLine("x>0 and y>0");
//     }
//     else if (quarter == 2)
//     {
//         Console.WriteLine("x<0 and y>0");
//     }
//     else if (quarter == 3)
//     {
//         Console.WriteLine("x<0 and y<0");
//     }
//     else if (quarter == 4)
//     {
//         Console.WriteLine("x>0 and y<0");
//     }
//     else Console.WriteLine("Введена некорректная четверть");
//     return;
// }

// Console.WriteLine("Введите четверть: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// GetCoordanatesFromQuarter(quarter);




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// double GetDistanceFromCoordinates(int AX, int AY,int BX, int BY)
// {
//     double result = Math.Sqrt((Math.Pow((BX - AX), 2) + Math.Pow((BY - AY), 2) ));
//     result = Math.Round(result, 2);
//     return result;
// }
// Console.WriteLine("Введите координату AX");
// int AX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату AY");
// int AY = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите координату BX");
// int BX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату BY");
// int BY = Convert.ToInt32(Console.ReadLine());


// double distance = GetDistanceFromCoordinates(AX, AY, BX, BY);
// Console.WriteLine($"Расстояние между точками = {distance}");

Console.Clear();



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void sqr(int N)
// {
//     if (N > 0)
//     {
//         int count = 1;
//         while (count <= N)
//         {
//             Console.Write(Math.Pow(count, 2) + " ");
//             count++;
//         }
//     }
//     else Console.WriteLine($" число {N} не соответствует условию ввода. Введите число больше 1. ");
// }

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// sqr(N);