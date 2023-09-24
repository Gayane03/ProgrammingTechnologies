string romNumber;
InputRomanNumber();

switch (romNumber.Length)
{
    case 1:
        Console.WriteLine("Value -> " + RomanAndValuePair(romNumber[0]));
        break;
    default:
        Console.WriteLine("Value -> " + OutputIntegerValue(romNumber));
        break;
}

void InputRomanNumber()
{
    do
    {
        Console.Clear();
        Console.Write("Input Roman number -> ");
        romNumber = Console.ReadLine();
        if (!LetterChecking(romNumber))
            romNumber = "";
    }
    while (romNumber.Length < 1 || romNumber.Length > 15 || romNumber == null);
}
int OutputIntegerValue(string rom)
{
    int answerValue = 0;
    for (int i = 0; i < romNumber.Length - 1; i++)
    {
        if (RomanAndValuePair(romNumber[i]) < RomanAndValuePair(romNumber[i + 1]))
        {
            answerValue = answerValue + RomanAndValuePair(romNumber[i + 1]) - RomanAndValuePair(romNumber[i]);
            ++i;
        }
        else if (i == romNumber.Length - 2)
            answerValue = answerValue + RomanAndValuePair(romNumber[i]) + RomanAndValuePair(romNumber[i + 1]);
        else
            answerValue += RomanAndValuePair(romNumber[i]);
    }
    return answerValue; 
}
int RomanAndValuePair(char rom)
{
    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>()
    {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
    };
    return keyValuePairs[rom];
}
bool LetterChecking(string rom)
{
    try
    {
        for (int i = 0; i < rom.Length; i++)
        {
            RomanAndValuePair(rom[i]);
        }
        return true;    
    }
    catch
    {
        return false;   
    }
}