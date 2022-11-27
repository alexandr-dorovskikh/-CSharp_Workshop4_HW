int NumDigitsSum(int num)
{
    int Result = 0;

    while (num > 0)
    {
        int LastDigit = num % 10;        
        
        Result += LastDigit;
        num = num / 10;     
    
    }

    return Result;
}

Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"digits sum = {NumDigitsSum(num)}");