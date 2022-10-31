using Superheroes.Modelo;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        List<Superheroe> listaSuperheroes;
        public MainWindow()
        {
            InitializeComponent();

            listaSuperheroes = Superheroe.GetSamples();


            contenedorDockPanel.DataContext = listaSuperheroes[i];
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            switch ((sender as Image).Tag.ToString())
            {
                case "Siguiente":
                    if (i+1 != 3)
                    {
                        contenedorDockPanel.DataContext = listaSuperheroes[++i];
                    }
                    break;
                case "Anterior":
                    if (i+1 != 1)
                    {
                        contenedorDockPanel.DataContext = listaSuperheroes[--i];

                    }
                    break;
            }
            heroeActualTextBlock.Text = i+1 + "/" + listaSuperheroes.Count;
        }
    }
}
