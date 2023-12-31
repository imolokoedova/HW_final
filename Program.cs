// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// сгенерировать массив из строк
// метод убирающий строки больше трех символов
// пробежаться по входному массиву посмотреть сколько элементов меньше 3 символов
// создать новый массив нужного размера
// положить символы в новый массив

string[] arr = {"Hello", "2", "world", ":-)"};
string[] newArr = FilterArray(arr);
PrintArray(newArr);

string[] FilterArray(string[] arr) 
{
    // находим кол-во элементов в новом массиве
    int newLength = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            newLength++;
        }
    }
    // создаем новый массив
    string[] newArr = new string[newLength];
    // копируем в новый массив элементы
    int j = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string elem = arr[i];
        if (i < arr.Length - 1)
            Console.Write($"{elem}, ");
        else
            Console.WriteLine($"{elem}");
    }
}