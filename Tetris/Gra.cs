using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Bloki;
namespace Tetris
{
    internal class Gra
    {
        public Plansza plansza = new Plansza();
        public bool GameOver = false;
        public BlokBaza Blok;
        public bool Loop=false;

    public void przesun_w_lewo()
        {
            bool moza = true;
            for (int i = 0; i < 26; i++)
            {
                if (plansza.pola[i, 0].status == 2)
                    moza = false;
                if (moza == true) break;
            }

            if (moza == true)
                for (int i = 0; i < 26; i++)
                    for (int j = 1; j < 10; j++)
                    {
                        if (plansza.pola[i, j].status == 2)
                            if (plansza.pola[i, j - 1].status == 1)
                                moza = false;
                        if (moza == true) break;
                    }
            if (moza == true)
            {
                for (int i = 0; i < 26; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (plansza.pola[i, j + 1].status == 2)
                        {
                            plansza.pola[i, j].status = 2;
                            plansza.pola[i, j].kolor = plansza.pola[i, j].kolor;
                            plansza.pola[i, j + 1].status = 0;
                            plansza.pola[i, j + 1].kolor = kolory.szary;
                        }
                    }
            }
        }

        public void przesun_w_prawo()
        {
            bool moza = true;
            for (int i = 0; i < 26; i++)
            {
                if (plansza.pola[i, 9].status == 2)
                    moza = false;
                if (moza == true) break;
            }

            if (moza == true)
                for (int i = 0; i < 26; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (plansza.pola[i, j].status == 2)
                            if (plansza.pola[i, j + 1].status == 1)
                                moza = false;
                        if (moza == true) break;
                    }
            if (moza == true)
            {
                for (int i = 0; i < 26; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (plansza.pola[i, 8 - j].status == 2)
                        {
                            plansza.pola[i, 9 - j].status = 2;
                            plansza.pola[i, 9 - j].kolor = plansza.pola[i, 8 - j].kolor;
                            plansza.pola[i, 8 - j].status = 0;
                            plansza.pola[i, 8 - j].kolor = kolory.szary;
                        }
                    }
            }
        }

        public void przezun_w_dol()
        {
            bool moza = true;
            for (int j = 0; j < 10; j++)
            {
                if (plansza.pola[25, j].status == 2)
                    moza = false;
                if (moza == true) break;
            }
            if (moza == true)
                for (int i = 0; i < 25; i++)
                    for (int j = 0; j < 10; j++)
                    {
                        if (plansza.pola[i, j].status == 2)
                            if (plansza.pola[i - 1, j].status == 1)
                                moza = false;
                        if (moza == true) break;
                    }
            if (moza == false)
                Loop = false;
            if (moza == true)
            {
                for (int i = 0; i < 25; i++)
                    for (int j = 0; j < 10; j++)
                    {
                        if (plansza.pola[24 - i, j].status == 2)
                        {
                            plansza.pola[25 - i, j].status = 2;
                            plansza.pola[25 - i, j].kolor = plansza.pola[24 - i, j].kolor;
                            plansza.pola[24 - i, j].status = 0;
                            plansza.pola[24 - i, j].kolor = kolory.szary;
                        }
                    }
            }
        }

        public void NowyZrzut()
        {
                Random rand = new Random();
                int num = rand.Next(7);
                switch (num)
                {
                    case 0:
                        Blok = new BlokI();
                        break;
                    case 1:
                        Blok = new BlokJ();
                        break;
                    case 2:
                        Blok = new BlokL();
                        break;
                    case 3:
                        Blok = new BlokO();
                        break;
                    case 4:
                        Blok = new BlokS();
                        break;
                    case 5:
                        Blok = new BlokT();
                        break;
                    case 6:
                        Blok = new BlokZ();
                        break;
                }
            int n = Blok.n;
            for(int i = 0;i < n;i++) 
            {
                for (int j = 0; i < n; j++)
                {
                    plansza.pola[3 - n - i, 4 + n - j] = Blok.pola[i, j];
                }
            }
        }

   
    }
}
