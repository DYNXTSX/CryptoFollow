using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.UCF
{
    /// <summary>
    /// Logique d'interaction pour UC_ChangeNews.xaml
    /// </summary>
    public partial class UC_ChangeNews : UserControl
    {
        public UC_ChangeNews()
        {
            InitializeComponent();
        }

        private void montant_TextChanged(object sender, TextChangedEventArgs e)
        {
            (Application.Current as App).allCryptos[Nom_Crypto.Text.ToString()].ValeurEuros = Double.Parse(montant.Text.ToString());
        }
    }
}
