int [] array = {1, 2, 3, 4, 5, 6, 55, 658, 9, 7, 89, 658, 658};

int n = array.Length;
int find = 658;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
