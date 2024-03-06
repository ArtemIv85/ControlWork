string[] srt = ["Hello", "2", "world", ":-)"];


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

Console.Write($"{CountElement(srt)}");