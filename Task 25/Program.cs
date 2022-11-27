int Pow(int a, int b)
{
    int Result = a;
    for (int i = 1; i < b; i++)
    {
        Result *= a; 
    }

    return Result;
}

string ToSuperscriptText(int num)
{
    string Result = "";
    while (num > 0)
    {
        int LastDigit = num % 10;
        string DigitChar = "";
        if (LastDigit == 1)
            DigitChar = "\xB9";
        else if (LastDigit == 2)
            DigitChar = "\xB2";
        else if (LastDigit == 3)
             DigitChar = "\xB3";            
        else 
            DigitChar = char.ConvertFromUtf32(8304 + LastDigit);
        
        Result = DigitChar + Result;
        num = num / 10;     
    
    }

    return Result;
}

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine($"{a}{ToSuperscriptText(b)} = {Pow(a, b)}");
