using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int number;
InputNumber(out number);//for input number function 

int numberLength = number.ToString().Length;
Stack<string> wordsNumber = new Stack<string>();//push armenian words
int tempRemainder = 10;//to calculate number remainder


for (int i = 1; i <= numberLength; i++)
{
    int digit = (number % tempRemainder) / (tempRemainder / 10);//take every last digit for the parametr

    if (digit == 0 && numberLength == 1)
    {
        wordsNumber.Push("Զրո");
        break;
    }
    else if (i % 3 == 1)
    {
        if (i == 7)
        {
            wordsNumber.Push(BigNumbers(3));
            wordsNumber.Push(SingleDigitNumbers(digit));
            break;
        }
        int temp = (number % 1000000) / 1000;
        if (i == 4 && temp > 0)
        {
            wordsNumber.Push(BigNumbers(2));
            if (digit == 1 && (temp % 1000 / 100 + temp % 100 / 10) == 0)
            {
                tempRemainder *= 10;
                continue;
            }
        }
        wordsNumber.Push(SingleDigitNumbers(digit));
    }
    else if (i % 3 == 2)
    {
        if (wordsNumber.Peek() == "" && digit == 1)
        {
            wordsNumber.Push(TensNumers(0));
        }
        else if (digit == 0)
        {
            tempRemainder *= 10;
            continue;
        }
        else
        {
            wordsNumber.Push(TensNumers(digit));
        }
    }

    else if (digit >= 1)
    {
        wordsNumber.Push(BigNumbers(1));
        if (digit != 1)
        { wordsNumber.Push(SingleDigitNumbers(digit)); }
    }//for the determination of hundreds
    tempRemainder *= 10;
}
OutputAnswer();//for output function 

void OutputAnswer()
{
    Console.Write("Answer -> ");
    foreach (string word in wordsNumber.ToArray())
    {
        Console.Write(word);
    }
    Console.WriteLine();
}
void InputNumber(out int number)
{
    do
    {
        Console.Clear();
        Console.Write("Input a non-negative number in the console that is not greater than the maxvalue of int: ");
        number = int.Parse(Console.ReadLine());
    }
    while (number < 0 || number > int.MaxValue);
}

string SingleDigitNumbers(int number)
{
    Dictionary<int, string> numbers = new Dictionary<int, string>
    {
        [0] = "",
        [1] = "մեկ",
        [2] = "երկու",
        [3] = "երեք",
        [4] = "չորս",
        [5] = "հինգ",
        [6] = "վեց",
        [7] = "յոթ",
        [8] = "ութ",
        [9] = "իննը"
    };
    return numbers[number];
}
string TensNumers(int number)
{
    Dictionary<int, string> nubers = new Dictionary<int, string>
    {
        [0] = " տաս ",
        [1] = " տասն",
        [2] = " քսան",
        [3] = " երեսուն",
        [4] = " քառասուն",
        [5] = " հիսուն",
        [6] = " վաթսուն",
        [7] = " յոթանասուն",
        [8] = " ութսուն",
        [9] = " իննսուն"
    };
    return nubers[number];
}
string BigNumbers(int number)
{
    Dictionary<int, string> nubers = new Dictionary<int, string>
    {
        [1] = " հարյուր ",
        [2] = " հազար ",
        [3] = " միլիոն ",
    };
    return nubers[number];
}
