using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tombola;

namespace Cartellone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GameUtil game = new GameUtil();
        List<int> ultimiUsciti = new List<int>();
        private byte temp;

        public MainWindow ()
        {
            InitializeComponent();
            game.OnPartitaTerminata += OnPartitaTerminata;
        }

        private void btn_Avvio_Click ( object sender , RoutedEventArgs e )
        {
            byte estratto = game.GetNumber();

            Label foundLabel = ( Label ) FindName( "lbl_" + estratto );

            foundLabel.Background = Brushes.Brown;
            foundLabel.IsEnabled = false;

            lbl_U.Content = estratto;

            FaiVedereUltimiUsciti();
            temp = estratto;


        }

        private void FaiVedereUltimiUsciti ()
        {
            lbl_03.Content = lbl_02.Content;
            lbl_02.Content = lbl_01.Content;
            lbl_01.Content = temp.ToString();

        }

        public void OnPartitaTerminata ()
        {
            MessageBox.Show( "Partita Terminata" );
            return;
        }

    }
}