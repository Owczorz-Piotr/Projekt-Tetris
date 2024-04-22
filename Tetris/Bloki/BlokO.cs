using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokO : BlokBaza
    {
        public BlokO()
        {
            int n = 2;
            System.Windows.Media.SolidColorBrush kolor = kolory.pomaranczowy;
            int[,] pozycja = new int[n, n];
            pozycja[0, 0] = 2;
            pozycja[0, 1] = 2;


            pozycja[1, 0] = 2;
            pozycja[1, 1] = 2;

        }

    }
}
