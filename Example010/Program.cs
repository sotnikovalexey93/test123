int [] array = {11,25,23,14,52,66,17,8};

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}