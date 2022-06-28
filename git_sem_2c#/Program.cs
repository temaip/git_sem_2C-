// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Воод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 99 && N < 1000)
// {
//     int x = N / 10 % 10;
// Console.WriteLine(N + "->" + x);
// }
// else Console.WriteLine("Число нетрехзначное");

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Воод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 99 && N < 1000)
// {
//     int x = N % 10;
//     Console.WriteLine(N + "->" + x);
// }
// else
// {
//     if (N > 999 && N < 10000)
//     {
//     int x = N / 10 % 10;
//     Console.WriteLine(N + "->" + x);
//     }
//     else
//     {
//         if (N > 9999 && N < 100000)
//         {
//             int x = N / 100 % 10;
//             Console.WriteLine(N + "->" + x);
//         }
//         else
//         {
//             if (N < 100)
//             {
//                 Console.WriteLine( "Третей цифры нет");
//             }
//             else
//             {
//                 if (N > 99999)
//                 {
//                     Console.WriteLine("Вы ввели слишком большое число, попробуйте ввести число до 99999.");
//                 }
//             }

//         }
//     }
// }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите день недели N");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 0 && N < 8)
// {
//     if ( N > 5 && N < 8 )
//     {
//         Console.WriteLine("Выходной");
//     }
//     else Console.WriteLine("Рабочий");

// }
// else Console.WriteLine("такого дня нет");
