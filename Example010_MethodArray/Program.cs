
int[] array = { 12, 92, 34, 42, 885, 36, 67, 81 };

int n = array.Length;
int find = 42;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index + 1);
        break;
    }
    index++;
}
