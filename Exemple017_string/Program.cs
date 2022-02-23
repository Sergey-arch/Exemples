// Двумерные массивы table

// string.Empty По умолчанию строки инициализируются пустой строкой
// table[0,0]  table[0,1]  table[0,2] ... table[0,4]
// table[0,0]  table[1,1]  table[1,2] ... table[1,4]

string[,] table = new string[2, 5];//2 это кол-во строк (Две строки но с индексами 0;1)
                    // 5 это кол-во столбцов (Пять столбцов но с индексами 0;1;2;3;4)

table[1, 2] = "слово"; // 1 это получается 2-я строка 
                       // 2 это получается 3-ий столбец;

for (int rows = 0; rows < table.GetLength(0); rows++) // rows - строки
{
    for (int columns  = 0; columns < table.GetLength(1); columns++) // columns - столбцы
    {
        Console.Write($"-{table[rows, columns]}- ");
    }
Console.WriteLine();
}




