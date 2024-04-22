using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokZ : BlokBaza
    {
        public BlokZ()
        {
            int n = 3;
            System.Windows.Media.SolidColorBrush kolor = kolory.zielony;
            int[,] pozycja = new int[n, n];
            pozycja[0, 0] = 0;
            pozycja[0, 1] = 0;
            pozycja[0, 2] = 0;

            pozycja[1, 0] = 0;
            pozycja[1, 1] = 2;
            pozycja[1, 2] = 2;

            pozycja[2, 0] = 2;
            pozycja[2, 1] = 2;
            pozycja[2, 2] = 0;
        }

    }
}
