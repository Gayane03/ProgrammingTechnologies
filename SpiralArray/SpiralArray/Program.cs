Console.Write("Input n x m :\nn -> ");
int n = int.Parse(Console.ReadLine());
Console.Write("m -> ");
int m = int.Parse(Console.ReadLine());
int[,] arr = new int[n, m];

int constantTemp = 0;//pahuma @ntacik toxi kam syan tiv@ vorum tver@ acelu en
int consX = m;//tvyal toxum qani qayl araj gna
int consY = n - 1; //tvyal syunum qani qayl araj gna 
int r = 0;//row
int c = -1;//column
int count = 0;//tveri aci hamar

for (int i = 0; i < n; i++)
{
    for (int j = 1; j <= consX + consY; j++)
    {
        if (i % 2 == 0)
        {
            if (j <= consX)
            {
                constantTemp = r;
                arr[constantTemp, ++c] = ++count;
                continue;
            }

            constantTemp = c;
            arr[++r, constantTemp] = ++count;

        }
        else
        {
            if (j <= consX)
            {
                constantTemp = r;
                arr[constantTemp, --c] = ++count;
                continue;
            }

            constantTemp = c;
            arr[--r, constantTemp] = ++count;

        }
    }
    consX = consX - 1;
    consY = consY - 1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
