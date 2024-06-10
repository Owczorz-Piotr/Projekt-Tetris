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
    public partial class MainWindow : Window
    {
        internal Gra gra = new Gra();
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
            int czas = 100000/ (100 + 8 * gra.Runda);
            gra = new Gra();
            gra.plansza.nowa_gra();
            gra.GameOver = false;
            while (!gra.GameOver)
            {
                gra.NowyZrzut();
                AktualizujPlansze();
                gra.Loop = true;
                while (gra.Loop)
                {
                    await Task.Delay(czas);
                    gra.przesun_w_dol();
                    AktualizujPlansze();
                }
            }
            MesKoniec();
        }

        private void Zapiszkolor(int column, int row)
        {
            string name = "C" + column + "R" + row;
            Rectangle rectangle = (Rectangle)MainGrid.FindName(name);

            if (rectangle != null)
            {
                rectangle.Fill = gra.plansza.pola[column, row+3].kolor;
            }
        }

        private void MesKoniec()
        {
            MessageBox.Show("Chyba przegrałeś, naciśniej F2, aby zagrać ponownie", "No i klops...", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
        }

        private async void Window_KeyDown(object sender, KeyEventArgs klawisz)
        {
            switch (klawisz.Key)
            {
                case Key.Left:
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
                case Key.Down:
                    {
                        if (gra.Loop)
                        {
                            gra.przesun_w_dol();
                            AktualizujPlansze();
                        }
                        break;
                    }
                case Key.Up:
                    {
                        if (gra.Loop)
                        {
                            gra.obrot();
                            AktualizujPlansze();
                        }
                        break;
                    }
                case Key.F2:
                    {
                        if (gra.GameOver)
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

        private void Pomoc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("F2 - nowa gra\n" +
                            "Strzałaka w prawo - przesuń blok w prawo\n" +
                            "Strzałaka w lewo - przesuń blok w lewo\n" +
                            "Strzałaka w dół - przesuń blok w doł\n" +
                            "Strzałaka w górę - obróć blok\n" +
                            "Esc - wyjdź");
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

