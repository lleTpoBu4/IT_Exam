using System.Collections; // Надеюсь это не запрещено.

string[] InputStringArray = { "Hello ", "my friend! ", "I did a ", "G", "ood jo", "B. ", "$", "o, if yo", "u", " want ", "to see ", "the magic, ", "p", "ress Ent", "e", "®", "!!!", " ;)" };
// Задал исходный массив строк

string[] SortMethod(string[] IncomeArray) // Немножечко магии, чтобы всё работало
{
    ArrayList Array = new ArrayList();
    for (int i = 0; i < IncomeArray.Length; i++)
    {
        if (IncomeArray[i].Length <= 3)
        {
            Array.Add(IncomeArray[i]);
        }
        else
            continue;
    }
    string[] NewArray = new string[Array.Capacity];
    Array.CopyTo(NewArray);
    return NewArray;
}

void PrintArray(string[] IncomeArray)// Метод вывода элементов массива в консоль
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomeArray.Length; i++)
    {
        ToPrint = ToPrint + "" + IncomeArray[i]; //Можно добавить разделитель в "", но с ним месседж выглядит неочень
    }
    Console.WriteLine(ToPrint);
}

// Можно было всё решить этой одной строкой, но я поздно нашёл этот метод
// string[] OutputStringArray = InputStringArray.Where(x => x.Length < 4).ToArray(); 

// Так что, чтоб зря не пропадало, будем испольовать мои "костыли"
string[] OutputStringArray = SortMethod(InputStringArray); // Сортируем исходный массив и переписываем элементы, подходящие под условия сортировки, в новый
OutputStringArray = OutputStringArray.Where(x => x != null).ToArray();// Убираем из полученного массива лишние элементы с "пустым" значением
Console.WriteLine("Исходный массив:"); // Что было
PrintArray(InputStringArray);
Console.ReadLine();
Console.WriteLine("Полученный массив:"); // Что стало
PrintArray(OutputStringArray);