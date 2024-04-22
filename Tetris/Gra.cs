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
        public bool GameOver;
        public bool Loop;
        public Queue<BlokBaza> queue_blok;


        public void dodaj_do_kolejki(Queue<BlokBaza> kolejka)
        { 
            Random rand = new Random();
            int num = rand.Next(7);
            switch (num) 
            { 
                case 0: 
                    kolejka.Enqueue(new BlokI());
                    break;
                case 1:
                    kolejka.Enqueue(new BlokJ());
                    break;
                case 2:
                    kolejka.Enqueue(new BlokL());
                    break;
                case 3:
                    kolejka.Enqueue(new BlokO());
                    break;
                case 4:
                    kolejka.Enqueue(new BlokS());
                    break;
                case 5:
                    kolejka.Enqueue(new BlokT());
                    break;
                case 6:
                    kolejka.Enqueue(new BlokZ());
                    break;
            }
        }
    public void przesun_w_lewo(Plansza plansza)
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

        public void przezun_w_prawo(Plansza plansza)
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

        public void przezun_w_dol(Plansza plansza, bool loop)
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
                loop = false;
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


    }
}
