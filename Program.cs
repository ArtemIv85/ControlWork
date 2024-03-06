using System.Runtime.ExceptionServices;

//Варианты входных массивов. Нужный расскоментировать
string[] str = ["Hello", "2", "world", ":-)"];
//string[] str = ["1234", "1567", "-2","computer science"];
//string[] str = ["Russia", "Denmark", "Kazan"];



/// <summary>
/// Функция создает новый массив с количеством элементов count и копирует туда строки удовлетворяжщие критерию
/// </summary>
/// <param name="array">Входящий массив</param>
/// <param name="n">целое число. отбираются строки длинна которых не превышает  это значение</param>
/// <returns>Возвращает новый массив</returns>
string[] NewArray(string[] array, int n)
{
    int count=0;
    for (int i =0; i<array.Length; i++) // цикл определения количества
                                        // подходящих строк для создания новго массива нужного размера
    {
        if (array[i].Length<=n)
        {
            count++;
        }
    }

    string[] result = new string[count]; // создание нового массива
    int j = 0;
    for (int i =0; i<array.Length; i++) // цикл копирования нужных элементов в новый массив
    {
        if (array[i].Length<=n)
            {
                result[j]=array[i];
                j++;
            }
    }
    return result;
}


Console.Clear();
Console.Write($"Изначальный массив: [{string.Join(" ; ",str)}] \n");
Console.Write($"Новый массив с элементами по условию: [{string.Join(" ; ",NewArray(str,3) )}]");
