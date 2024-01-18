﻿// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4   

// int [,] array = new int[3,4];


// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++)
//         {
//         array[i,j]= new Random().Next(0,10);

//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j]+ " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++)
//         {
//             if(i%2==0 && j%2 ==0)    
//             {
//                 array[i,j] *= array[i,j];
//             }
//         }
//     }
// }


// GetArray();
// PrintArray();
// ChangeArray();
// System.Console.WriteLine();
// PrintArray();


// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int [,] array = new int[3,4];

void GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
        array[i,j]= new Random().Next(0,10);

        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+ " \t ");
        }
        System.Console.WriteLine();
    }
}

int GetSum()
{
    int sum= 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            if(i==j)    
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

GetArray();
PrintArray();

System.Console.WriteLine(GetSum());