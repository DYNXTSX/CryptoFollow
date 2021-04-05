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
using MonModele;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour AddCrypto.xaml
    /// </summary>
    public partial class AddCrypto : Window
    {
        public AddCrypto()
        {
            InitializeComponent();
        }

        private void validerCrypto(object sender, RoutedEventArgs e)
        {
            if (nomCrypto.Text.ToString() == "" || nomCrypto.Text.ToString() == "nom")
                MessageBox.Show("Saisir un nom");
            else if (imageCrypto.Text.ToString() == "" || imageCrypto.Text.ToString() == "image")
                MessageBox.Show("Saisir une image");
            else if(combienJAI.Text.ToString() == "" || combienJAI.Text.ToString() == "xxx")
                MessageBox.Show("Saisir un montant");
            else if(coutCrypto.Text.ToString() == "" || coutCrypto.Text.ToString() == "xxx")
                MessageBox.Show("Saisir un montant");
            else
            {
                (Application.Current as App).allCryptos.LesCryptos.Add(
                    new Crypto(nomCrypto.Text.ToString(), 
                    imageCrypto.Text.ToString(), 
                    Convert.ToDouble(coutCrypto.Text.ToString()), 
                    Convert.ToDouble(combienJAI.Text.ToString()),
                    Convert.ToDouble(cbnJai.Text.ToString())
                    ));
                Close();
            }
        }
    }
}
