using System;
using System.IO;
using MonModele;

namespace Data
{
    public class Stub
    {
        public static EnsembleCrypto CreeCryptoBase()
        {
            EnsembleCrypto listeCrypto = new EnsembleCrypto();

            if (File.Exists("data.bin"))
                listeCrypto.Chargement();
            else
            {
                listeCrypto.LesCryptos.Add(new Crypto("Bitcoin", "https://research.binance.com/static/images/projects/bitcoin/logo.png", 50000, 0.001,1));
            }

            return listeCrypto;
        }
        

    }
}
