using System.Windows;
using System.Windows.Controls;

namespace Cartellina
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CartellinaController cartellinaController = new CartellinaController();


        public MainWindow ()
        {
            InitializeComponent();
            InitializeCartellina();
        }

        private void InitializeCartellina ()
        {
            for ( int i = 0 ; i < cartellinaController.NumeriCartellina.Length ; i++ )
            {
                Label foundLabel = FindName( "lbl_" + ( i + 1 ).ToString() ) as Label;
                foundLabel.Content = cartellinaController.NumeriCartellina[ i ].ToString();
                //foundLabel.Background = Brushes.Brown;
            }
        }

        private void btn_Avvio_Click ( object sender , RoutedEventArgs e )
        {
            InitializeCartellina();

        }
    }
}
