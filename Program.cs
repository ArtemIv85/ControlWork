using System.Runtime.ExceptionServices;

string[] str = ["Hello", "2", "world", ":-)"];


int CountElement(string[] array)
{
    int count=0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count++;
        }
    }

    return count;
}

string[] NewArray(string[] array, int count)
{
    string[] result = new string[2];
    int j = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
            {
                result[j]=array[i];
                j++;
            }
    }
    return result;
}

Console.Write($"Изначальный массив: [{string.Join(";",str)}]");
Console.Write($"  [{string.Join(";",NewArray(str, CountElement(str))    )}]");
