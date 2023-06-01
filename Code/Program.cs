int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    while (result < 1)
{
    result = Prompt("Некорректный ввод, введите положительное целое число: ");
}
    return result;
}

void FillArray(string[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.WriteLine("Введите элемент: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
        Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"\"{array[i]}\"");
        }
        else Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int HowLongArray(string[] array, int num)
{
    int newSize = 0;
    for (int i = 0; i<array.Length;i++)
    {
        if (array[i].Length<=num)
        {
            newSize+=1;
        }
    }
    return newSize;
}

string[] SelectArray(string[] array, int size, int num)
{
    int k = 0;
    string[] newArray = new string[size];
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i].Length<=num)
        {
            newArray[k]=array[i];
            k+=1;
        }
    }
    return newArray;
}

int userSize = Prompt("Введите размер массива: ");
string[] userArray = new string[userSize];
FillArray(userArray);
PrintArray(userArray);
int symbolLimit = Prompt("Введите максимальную длину строк для нового массива: ");
int resultSize = HowLongArray(userArray, symbolLimit);
string[] resultArray = SelectArray(userArray, resultSize, symbolLimit);
PrintArray(resultArray);
