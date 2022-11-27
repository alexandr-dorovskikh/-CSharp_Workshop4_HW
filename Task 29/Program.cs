void GetNumToArray(int index, ref int[] NumsArray)
{
    Console.Write($"num{index + 1} = ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    NumsArray[index] = num;
}

void PrintArray(int[] NumsArray)
{
    int ArraySize = NumsArray.Length;
    
    Console.Write("[");
    
    for (int i = 0; i < ArraySize; i++)
    {
        Console.Write(NumsArray[i]);
        if (i < ArraySize - 1) Console.Write(", ");
    }
    
    Console.Write("]");
}

int SIZE = 8;

int[] NumsArray = new int[SIZE];

for (int i = 0; i < SIZE; i++)
{
    GetNumToArray(i, ref NumsArray);
}

PrintArray(NumsArray);