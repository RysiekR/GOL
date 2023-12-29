Console.WriteLine("Hello, World!");
int x = 32;
int[,] tablica = new int[x, x];
int[,] tablicaKopia = new int[x, x];
int wynik = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < x; j++)
    {
        Random rnd = new Random();
        int dayNight = rnd.Next(0, 2);
        tablica[i, j] = dayNight;

    }
}

while (true)
{
    int tw = x;
    {
        for (int i = 0; i < tw; i++)
        {
            for (int j = 0; j < tw; j++)
            {
                for (int calcOne = -1; calcOne < 2; calcOne++)
                {
                    for (int calcTwo = -1; calcTwo < 2; calcTwo++)
                    {
                        int neighbourOne = i + calcOne;
                        int neighbourTwo = j + calcTwo;

                        if (neighbourOne < 0) { neighbourOne = x - 1; }
                        if (neighbourTwo < 0) { neighbourTwo = x - 1; }
                        if (neighbourOne >= x) { neighbourOne = 0; }
                        if (neighbourTwo >= x) { neighbourTwo = 0; }

                        if (!(calcOne == 0 && calcTwo == 0))
                        {
                            wynik = wynik + tablica[neighbourOne, neighbourTwo];
                        }

                    }
                }

                if (tablica[i, j] == 1)
                {
                    if (wynik == 2 || wynik == 3)
                    {
                        wynik = 1;
                    }
                    else
                    {
                        wynik = 0;
                    }
                }
                else
                {
                    if (wynik == 3)
                    {
                        wynik = 1;
                    }
                    else
                    {
                        wynik = 0;
                    }
                }
                tablicaKopia[i, j] = wynik;
                Console.Write(tablicaKopia[i, j] + "  ");
                wynik = 0;
            }
            Console.WriteLine("");

        }
        Console.WriteLine("Pause");

    }

    // for (int ii = 0; ii < tw; ii++)
    // {
    //     for (int jj = 0; jj < tw; jj++)
    //     {
    //         Console.Write(tablica[ii, jj] + "  ");
    //     }
    //     Console.WriteLine("");

    // }
    tablica = (int[,])tablicaKopia.Clone();

    Console.ReadLine();
}

// void DrawRectangle (System.Drawing.Pen pen, int 0, int 0, int 100, int 100){};

