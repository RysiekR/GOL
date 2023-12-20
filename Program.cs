Console.WriteLine("Hello, World!");
int[,] LD = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
int tw = 5;
for (int t = 0; t < 2; t++)
{
    for (int i = 0; i < tw; i++)
    {
        for (int j = 0; j < tw; j++)
        {
            Console.Write(LD[i, j]);

            if(LD[i,j]==2)
            {
                LD[i,j]=3;
            }
        }
        Console.WriteLine("");

    }
    Console.WriteLine("");

}
Console.ReadLine();