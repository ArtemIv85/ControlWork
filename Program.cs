using System.Runtime.ExceptionServices;

//Варианты входных массивов. Нужный расскоментировать
string[] str = ["Hello", "2", "world", ":-)"];
//string[] str = ["1234", "1567", "-2","computer science"];
//string[] str = ["Russia", "Denmark", "Kazan"];


/// <summary>
/// Функция возвращает соличество элементов менше или равно n
/// </summary>
/// <param name="array">Входящий массив состоящий из строй</param>
/// <param name="n">целое число. отбираются строки длинна которых не превышает  это значение</param>
/// <returns>Возвращает количество строк в массиве удовлетворяющее критерию</returns>
int CountElement(string[] array, int n)
{
    int count=0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i].Length<=n)
        {
            count++;
        }
    }

    return count;
}


/// <summary>
/// Функция создает новый массив с количеством элементов count и копирует туда строки удовлетворяжщие критерию
/// </summary>
/// <param name="array">Входящий массив</param>
/// <param name="count">количество элементов в новом массиве.  Должно быт определено заранее</param>
/// <param name="n">целое число. отбираются строки длинна которых не превышает  это значение</param>
/// <returns>Возвращает новый массив</returns>
string[] NewArray(string[] array, int count, int n)
{
    string[] result = new string[count];
    int j = 0;
    for (int i =0; i<array.Length; i++)
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
Console.Write($"Новый массив с элементами по условию: [{string.Join(" ; ",NewArray(str, CountElement(str,3),3) )}]");
