using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokI : BlokBaza
    {
        public BlokI()
        {
            int n = 4;
            System.Windows.Media.SolidColorBrush kolor = kolory.niebieski;
            int[,] pozycja = new int[n, n];
            pozycja[0, 0] = 2;
            pozycja[0, 1] = 0;
            pozycja[0, 2] = 0;
            pozycja[0, 3] = 0;

            pozycja[1, 0] = 2;
            pozycja[1, 1] = 0;
            pozycja[1, 2] = 0;
            pozycja[1, 3] = 0;

            pozycja[2, 0] = 2;
            pozycja[2, 1] = 0;
            pozycja[2, 2] = 0;
            pozycja[2, 3] = 0; 
        }

    }
}
