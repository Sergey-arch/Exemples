// ВИД 1     Метод 1
/*
void Metod1()
{
    Console.WriteLine("Автор Иванов И. И.  ");
}
Metod1();
*/

// ВИД 2     Метод 2
/*
void Method2(string msg)
{
    Console.WriteLine("msg");
}
// Method2("Тектовое сообщение");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текcт", count: 4); /* Method21("Текcт", 4); тоже самое
                                     Method21(count: 4, msg: "Текcт");
*/

// ВИД 3     Метод 3
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

// ВИД 4     Метод 4

string Method4(int count, string text) //строку с будем компановать count раз
{
    int i = 0;
    string result = String.Empty; // первоначально будет пустой строкой
                                  // или string result = "" тоже самое
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);