using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris
{
    public class Plansza
    {
        public Pole[,] pola = new Pole[10, 26];

        public void nowa_gra()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 26; j++)
                {
                    pola[i, j] = new Pole()
                    {
                        status = 0,
                        kolor = Brushes.Gray
                    };
                }
        }
    }
}
