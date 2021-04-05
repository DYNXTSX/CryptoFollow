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
using MonModele;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            afficheurCryptos.DataContext = (Application.Current as App).allCryptos;
            OpenNews();
        }

        private void OpenNews()
        {
            NewsWindow news = new NewsWindow();
            news.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (Application.Current as App).allCryptos.Sauvegarde();
        }

        private void afficheurCryptos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AjoutCrypto(object sender, RoutedEventArgs e)
        {
            AddCrypto ajout = new AddCrypto();
            ajout.ShowDialog();
        }
    }
}
