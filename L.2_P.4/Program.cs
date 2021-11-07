void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }

} 

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int CO = collection.Length;
    int IN = 0;
    int POS = 0;
    while(IN < CO)
    {
        if(collection[IN] == find)
        {
            POS = IN;
            break;

        }
        
        IN++;
    }
    return POS;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos1 = Indexof(array, 5);
Console.WriteLine(pos1);