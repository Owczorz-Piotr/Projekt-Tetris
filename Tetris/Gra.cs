using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Tetris.Bloki;
namespace Tetris
{
    internal class Gra
    {
        public Plansza plansza = new Plansza();
        public bool GameOver = true;
        public BlokBaza Blok;
        public bool Loop=false;
        public int Runda = 0;

    public void przesun_w_lewo()
        {
            bool mozePrzesunac = true;

            for (int j = 0; j < 26; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        if (i == 0 || plansza.pola[i - 1, j].status == 1)
                        {
                            mozePrzesunac = false;
                            break;
                        }
                    }
                }
                if (!mozePrzesunac) break;
            }

            if (mozePrzesunac)
            {
                for (int j = 0; j < 26; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (plansza.pola[i, j].status == 2)
                        {
                            plansza.pola[i - 1, j].status = 2;
                            plansza.pola[i - 1, j].kolor = plansza.pola[i, j].kolor;
                            plansza.pola[i, j].status = 0;
                            plansza.pola[i, j].kolor = Brushes.Gray;
                        }
                    }
                }
            }
        }

        public void przesun_w_prawo()
        {
            bool mozePrzesunac = true;

            for (int j = 0; j < 26; j++)
            {
                for (int i = 9; i >= 0; i--)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        if (i == 9 || plansza.pola[i + 1, j].status == 1)
                        {
                            mozePrzesunac = false;
                            break;
                        }
                    }
                }
                if (!mozePrzesunac) break;
            }

            if (mozePrzesunac)
            {
                for (int j = 0; j < 26; j++)
                {
                    for (int i = 9; i >= 0; i--)
                    {
                        if (plansza.pola[i, j].status == 2)
                        {
                            plansza.pola[i + 1, j].status = 2;
                            plansza.pola[i + 1, j].kolor = plansza.pola[i, j].kolor;
                            plansza.pola[i, j].status = 0;
                            plansza.pola[i, j].kolor = Brushes.Gray;
                        }
                    }
                }
            }
        }

        public void przesun_w_dol()
        {
            bool mozePrzesunac = true;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 25; j >= 0; j--)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        if (j == 25 || plansza.pola[i, j + 1].status == 1)
                        {
                            mozePrzesunac = false;
                            break;
                        }
                    }
                }
                if (!mozePrzesunac) break;
            }

            if (mozePrzesunac)
            {
                for (int j = 25; j >= 0; j--)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (plansza.pola[i, j].status == 2)
                        {
                            plansza.pola[i, j + 1].status = 2;
                            plansza.pola[i, j + 1].kolor = plansza.pola[i, j].kolor;
                            plansza.pola[i, j].status = 0;
                            plansza.pola[i, j].kolor = Brushes.Gray;
                        }
                    }
                }
            }
            else
            {
                usun();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (plansza.pola[i, j].status == 2)
                        {
                            GameOver=true;
                            Loop = false;
                            break;
                        }
                    }
                }
                if (!GameOver)
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 4; j < 26; j++)
                    {
                        if (plansza.pola[i, j].status == 2)
                        {
                            plansza.pola[i, j].status = 1;
                        }
                    }
                }
                Loop = false;
            }
        }

        public void usun()
        {
            for (int j = 0; j < 26; j++)
            {
                bool pelny = true;

                for (int i = 0; i < 10; i++)
                {
                    if (plansza.pola[i, j].status == 0)
                    {
                        pelny = false;
                        break;
                    }
                }

                if (pelny)
                {
                    for (int k = j; k > 0; k--)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            plansza.pola[i, k].status = plansza.pola[i, k - 1].status;
                            plansza.pola[i, k].kolor = plansza.pola[i, k - 1].kolor;
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        plansza.pola[i, 0].status = 0;
                        plansza.pola[i, 0].kolor = Brushes.Gray;
                    }
                    Runda++;
                    j--;
                }
            }
        }

        public void NowyZrzut()
        {
            Random rand = new Random();
            int num = rand.Next(7);
            switch (num)
            {
                case 0: Blok = new BlokI(); break;
                case 1: Blok = new BlokJ(); break;
                case 2: Blok = new BlokL(); break;
                case 3: Blok = new BlokO(); break;
                case 4: Blok = new BlokS(); break;
                case 5: Blok = new BlokT(); break;
                case 6: Blok = new BlokZ(); break;
            }

            int n = Blok.n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Blok.pola[i, j].status != 0)
                    {
                        plansza.pola[4 + i, 4 - n + j].status = Blok.pola[i, j].status;
                        plansza.pola[4 + i, 4 - n + j].kolor = Blok.pola[i, j].kolor;
                    }
                }
            }
        }


        //Tu znajduje się obracanie, przez które prawie się popłakałem :)
        public void obrot()
        {
            //liczenie środka bloku
            Brush kolor = Brushes.Gray;
            int centrumX = 0;
            int centrumY = 0;
            int liczbaPunktow = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        centrumX += i;
                        centrumY += j;
                        liczbaPunktow++;
                    }
                }
            }

            if (liczbaPunktow == 0) return;

            centrumX /= liczbaPunktow;
            centrumY /= liczbaPunktow;
            
            //sprawdzenie pozycji czy można
            List<(int, int)> nowePozycje = new List<(int, int)>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        int relX = i - centrumX;
                        int relY = j - centrumY;

                        int newRelX = relY;
                        int newRelY = -relX;

                        int noweX = centrumX + newRelX;
                        int noweY = centrumY + newRelY;

                        if (noweX < 0 || noweX >= 10 || noweY < 0 || noweY >= 26 || plansza.pola[noweX, noweY].status == 1)
                        {
                            return;
                        }

                        nowePozycje.Add((noweX, noweY));
                        kolor = plansza.pola[i, j].kolor;
                    }
                }
            }

            //czyścimy poprzednie chopy
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (plansza.pola[i, j].status == 2)
                    {
                        plansza.pola[i, j].status = 0;
                        plansza.pola[i, j].kolor = Brushes.Gray;
                    }
                }
            }

            // Wstawiamy na nowe pozycje
            foreach (var (noweX, noweY) in nowePozycje)
            {
                plansza.pola[noweX, noweY].status = 2;
                plansza.pola[noweX, noweY].kolor = kolor;
            }
        }
    }
}
