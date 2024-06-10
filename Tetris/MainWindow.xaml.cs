using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Tetris
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Gra gra;
        public MainWindow()
        {
            InitializeComponent();
            GenerujGrid(MainGrid);

        }
        void GenerujGrid(Grid grid)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 23; j++)
                {
                    Rectangle rectangle = new Rectangle
                    {
                        Fill = Brushes.Gray
                    };

                    string rectName = "C" + i + "R" + j;
                    rectangle.Name = rectName;
                    this.RegisterName(rectName, rectangle);
                    Grid.SetColumn(rectangle, i);
                    Grid.SetRow(rectangle, j);
                    grid.Children.Add(rectangle);
                }
            }
        }
        private async Task NowaGra()
        {

            gra = new Gra();
            gra.plansza.nowa_gra();
            gra.Loop = true;
            while (!gra.GameOver)
            {
                gra.NowyZrzut();
                while (gra.Loop)
                {
                    await Task.Delay(700);

                }
            }
        }

        private void Zapiszkolor(int column, int row)
        {
            string name = "C" + column + "R" + row;
            Rectangle rectangle = (Rectangle)MainGrid.FindName(name);

            if (rectangle != null)
            {
                rectangle.Fill = gra.plansza.pola[column, row-1].kolor;
            }
        }

        private async Task Window_KeyDown(object sender, KeyEventArgs klawisz)
        { 
        switch(klawisz.Key)
            {    case Key.Left:
                    {
                        if (gra.Loop)
                        {
                            gra.przesun_w_lewo();
                            AktualizujPlansze();
                        }
                        break;
                    }
                case Key.Right:
                    {
                        if (gra.Loop)
                        { 
                            gra.przesun_w_prawo();
                            AktualizujPlansze();
                        }
                        break;
                    }
                case Key.Up:
                    {
                        //if (Loop)
                        //{
                        //gra.obroc();
                        //AktualizujPlansze();
                        //}
                        //}
                        break;
                    }

                case Key.F2:
                    {
                        if (gra == null || gra.GameOver)
                        {
                            await NowaGra();
                        }
                        break;
                    }
                case Key.Escape:
                    {
                        this.Close();
                        break;
                    }
            }

        }
        private void AktualizujPlansze()
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 1; j < 23; j++)
                    {
                        Zapiszkolor(i, j);
                    }
                }
            }
    }


}

