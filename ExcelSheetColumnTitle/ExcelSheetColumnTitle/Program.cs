Console.WriteLine(ConvertToTitle(25698));

string ConvertToTitle(int columnNumber)
{
    Stack<char> forAnswer = new();

    while (columnNumber > 0)
    {
        forAnswer.Push(columnNumber % 26 == 0 ? 'Z' : (char)(64 + columnNumber % 26));
        columnNumber = (columnNumber - (columnNumber % 26 == 0 ? 26 : columnNumber % 26)) / 26;
    }

    return new string(forAnswer.ToArray());
}