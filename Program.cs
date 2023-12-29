Console.WriteLine("Hello, World!");
int x = 32;
int[,] tablica = new int[x, x];
int[,] tablicaKopia = new int[x, x];
int wynik = 0;
int population = 0;
int maxPopulation = x * x;
while (true)
{

    Console.WriteLine("What chance to populate you want?(type using numbers 1-100)");
    string? percentstr = Console.ReadLine()?.ToLower().Trim();
    int percent = Convert.ToInt32(percentstr);
    bool playbool = true;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Random rnd = new Random();
            int dayNight = rnd.Next(1, 101);

            if (dayNight < percent)
            {
                dayNight = 1;
            }
            else
            {
                dayNight = 0;
            }

            tablica[i, j] = dayNight;

        }
    }
    Console.WriteLine("First Population:");

    int tw = x;
    for (int ii = 0; ii < tw; ii++)
    {
        for (int jj = 0; jj < tw; jj++)
        {
            Console.Write(tablica[ii, jj] + "  ");
            if (tablica[ii, jj] == 1)
            {
                population++;
            }

        }

        Console.WriteLine("");
    }
    float procPopulation = ((population * 100) / (maxPopulation));
    Console.WriteLine($"Population: {population} ({procPopulation}%) / Max Population:{maxPopulation}");
    population = 0;
    Console.WriteLine("");

    while (playbool)
    {
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
                    if (wynik == 1)
                    {
                        population++;
                    }
                    tablicaKopia[i, j] = wynik;
                    Console.Write(tablicaKopia[i, j] + "  ");
                    wynik = 0;
                }
                Console.WriteLine("");

            }
            procPopulation = ((population * 100) / (maxPopulation));
            Console.WriteLine($"Population: {population} ({procPopulation}%) / Max Population:{maxPopulation}");
            population = 0;

        }

        tablica = (int[,])tablicaKopia.Clone();

        Console.WriteLine("Q to restart");
        string? quit = Console.ReadLine()?.ToLower().Trim();

        if (quit == "q")
        {
            playbool = false;
        }
    }

    // void DrawRectangle (System.Drawing.Pen pen, int 0, int 0, int 100, int 100){};


}