﻿// Двумерные массивы matrix ПРИМЕР



void PrintArray(int[,] matr) //МЕТОД матрица которая будет печатать таблицу (с 0 (пустыми)) ((((3)))) ((((8))))
{
    for (int i = 0; i < matr.GetLength(0); i++)//для выбора кол-ва строк от: 0; 1; 2;
                   // matrix.GetLength(0) это вместо 3; (0) - это индекс массива
    {   
        for (int j  = 0; j < matr.GetLength(1); j++) // для выбора кол-ва столбцов от: 0; 1; 2; 3;
                    // matrix.GetLength(1) это вместо 4; (1) - это индекс массива
        {
            Console.Write($"{matr[i, j]} "); // Напечатать строку с 4 колонками
        }
    Console.WriteLine();//принудительно перевести на новую строку по окончании колонок(4)
    }
}

void FillArray(int[,] matr) // МЕТОД матрица которая будет заполнять случайными числами ((((5))))
{
    for (int i = 0; i < matr.GetLength(0); i++)//для выбора кол-ва строк от: 0; 1; 2;
                   // matrix.GetLength(0) это вместо 3; (0) - это индекс массива
    {   
        for (int j  = 0; j < matr.GetLength(1); j++) // для выбора кол-ва столбцов от: 0; 1; 2; 3;
                    // matrix.GetLength(1) это вместо 4; (1) - это индекс массива
        {
            matr[i,j] = new Random().Next(1,20);
        }
    }
}

int[,] matrix = new int[3, 4]; // Задали три строки. четыре столбца (((((1)))))
PrintArray(matrix); // Сначало напечатали пустую таблицу с нулями ((((((2))))))
FillArray(matrix);  // Потом заполнили таблицу с Random числами ((((4))))
Console.WriteLine();//принудительно перевести на новую строку по окончании печати "0" ((((6))))
PrintArray(matrix); // Затем напечатали заполненную таблицу с Random числами (((7)))
