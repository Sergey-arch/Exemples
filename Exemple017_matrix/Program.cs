// Двумерные массивы matrix

string[,] table = new string[2, 5];
// string.Empty По кмолчанию строки инициализируются пустой строкой
// table[0,0]  table[0,1]  table[0,2] ... table[0,4]
// table[0,0]  table[1,1]  table[1,2] ... table[1,4]
/*
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns  = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

int[,] matrix = new int[3, 4]; // три строки. четыре столбца

for (int i = 0; i < matrix.GetLength(0); i++)//для выбора кол-ва строк от: 0; 1; 2;
                // matrix.GetLength(0) это вместо 3; (0) - это индекс массива
{   
    for (int j  = 0; j < matrix.GetLength(1); j++) // для выбора кол-ва столбцов от: 0; 1; 2; 3;
                // matrix.GetLength(1) это вместо 4; (1) - это индекс массива
    {
        Console.Write($"{matrix[i, j]} "); // Напечатать строку с 4 колонками
    }
Console.WriteLine();//принудительно перевести на новую строку по окончании колонок(4)
}