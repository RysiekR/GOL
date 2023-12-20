Console.WriteLine("Hello, World!");
int[,] LD = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
int tw = 5;
for (int t = 0; t < 2; t++)
{
    for (int i = 0; i < tw; i++)
    {
        for (int j = 0; j < tw; j++)
        {
            int wynik = LD[i,j];
            if((i>=1 && i<4) && (j>=1 && j<4))
            {

                wynik = (LD[i-1,j-1]+LD[i-1,j]+LD[i-1,j+1]+LD[i,j-1]+LD[i,j]+LD[i,j+1]+LD[i+1,j-1]+LD[i+1,j]+LD[i+1,j+1]);
            }
            LD[i,j]= wynik;
            Console.Write(LD[i,j] + "  ");
        }
        Console.WriteLine("");

    }
    Console.WriteLine(".");

}
Console.ReadLine();