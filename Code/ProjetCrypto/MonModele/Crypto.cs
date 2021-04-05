using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MonModele
{
    [Serializable()]
    public class Crypto
    {
        public ArrayList historiquesMontant { get; set; }
        public string Image { get; set; }
        public string Nom { get; }
        public double ValeurEuros { get; set; }
        public double NbCrypto { get; set; }
        public double InvestissementDepart { get; set; }
        public double Benef { get; set; }

        public Crypto(string nom, string image, double valeurEuros, double nbCrypto, double investissement)
        {
            Nom = nom;
            Image = image;
            ValeurEuros = valeurEuros;
            NbCrypto = nbCrypto;
            InvestissementDepart = investissement;
            Benef = NbCrypto * ValeurEuros - InvestissementDepart;
            historiquesMontant = new ArrayList();
        }

        public Crypto(string nom, string image, double valeurEuros, double nbCrypto, double investissement, ArrayList monHisto)
        {
            Nom = nom;
            Image = image;
            ValeurEuros = valeurEuros;
            NbCrypto = nbCrypto;
            InvestissementDepart = investissement;
            Benef = NbCrypto * ValeurEuros - InvestissementDepart;
            historiquesMontant = monHisto;
        }
    }
}
