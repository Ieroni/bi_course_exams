//написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести как с клавиатуры так + и использовать исходно заданный. 
//+Предложить перед стартом программы выбрать программу
using System;
Console.Clear();
Console.WriteLine("==========1th section Exam==========");

//Ввод
string[] userInput= DisplayMenu();

//Вывод результатов
Console.WriteLine();
string[] TempFilrArr = FilterArray(userInput);
Console.Write("полученный массив: ");
PrintRezultArray(TempFilrArr);

///=============================Методы========================================
//-М- метода задания исходного массива или выбора предложенного
string[] DisplayMenu()
{
    // Вывести пользователю предложение о выбора метода задания массива
    Console.WriteLine("1. Введите массив с клавиатуры");
    Console.WriteLine("2. Выбор массива по умолчанию");
    Console.Write("Введите цифру вашего выбора: ");
    string choice = Console.ReadLine() ?? "0";

    // инициализация массива
    char[] separators = new char[] { ' ', '.', ',' }; // выделение лишних символов, которые могут быть введены
    string[] arrayLine = new string[0];

    if (choice == "1")
    {
        Console.Write("Введите массив данных (через запятую, без пробелов): ");
        string input = Console.ReadLine() ?? "0";
        arrayLine = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }
    else if (choice == "2")
    { arrayLine = new string[] { "App5", "cat", "151", "5ex", "Enigma", "5555", "id8" }; }
    else
    { Console.WriteLine("Неправильный выбор метода"); }

    Console.Write("исходный массив: ");
    PrintRezultArray(arrayLine);
    return arrayLine;
}

//-М- метода фильтрации введеного массива по длине символа в строке
string[] FilterArray(string[] arr)
{
    // Подсчет кол-ва строк с количеством символов меньше 3
    int count = 0;
    foreach (string s in arr)
    {
        if (s.Length <= 3)
        {
            count++;
        }
    }
    Console.WriteLine("кол-во введеных строк с длиной символов не больще трех: " + count);

    // создание нового массива строк из отфильтрованных значений
    string[] filteredArr = new string[count];
    int index = 0;
    foreach (string s in arr)
    {
        if (s.Length <= 3)
        {
            filteredArr[index] = s;
            index++;
        }
    }

    return filteredArr;
}

//-М- метод для печати массива строк
void PrintRezultArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}