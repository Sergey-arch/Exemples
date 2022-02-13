// 

void FillArray(int[] collection)     // Void который будет заполнять массив
{
    int length = collection.Length;  // Получить длину нашего массива
    int index = 0;                   // Взять позицию которая будет начинаться с 0
    while (index < length)          // Пока индекс меньше длинны МАССИВА
    {
        collection[index] = new Random().Next(1, 10); // обратится к коллекции
                                                      // на позицию индекс
                                                     // и положить туда новое
                                                     // случайное число от 1 до 10
        index++;               //index = index + 1;
    }
}

void PrintArray(int[] col) // Void который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length; // Определяем кол-во элементов(count) 
    int index = 0;                 // Потребуются идексы щелкать массивы
    int position = -1;            // Создадим новую переменную для 37 строчки
    while (index < count)
    {
        if (collection[index] == find) // Если collection[index] совпал с find
        {
            position = index;      // Впозицию положим наше значение ИНДЕКСА
            break;                // Принахождении первого числа КОНЕЦ РАБОТЫ
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создали новый элемент в котором будет 10 элементов

FillArray(array); // Вызвали МЕТОД FillArray Который заполнил наш МАССИВ
array[4] = 4;     // Принудительно добавили на 4 позицию цифру 4
array[6] = 4;     // Принудительно добавили на 6 позицию цифру 4


PrintArray(array); // Распечатаем наш массив
Console.WriteLine();

int pos = IndexOf(array, 444); // Определим переменную pos и положим результат 
                               // работы метода IndexOf в качестве аргумента
                               // будет передоваться наш МАССИВ и например 
                               //будем искать 4
Console.WriteLine(pos);  // После того как метод отработает мы покажем на 
                          // экране pos
