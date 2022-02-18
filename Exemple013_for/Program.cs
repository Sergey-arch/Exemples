// for Цикл со счетчиком
/*
for (int i = 0; i < 10; i++)
{
   Console.WriteLine(i); 
}
*/

// ВИД 4     Метод 4

string Method4(int count, string text) //строку с будем компановать count раз
{
    string result = String.Empty; // первоначально будет пустой строкой
                                  // или string result = "" тоже самое
    for (int i = 0; i < count;i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);