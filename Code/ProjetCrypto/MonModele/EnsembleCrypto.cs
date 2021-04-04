using System;
using System.Collections;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MonModele
{
    [Serializable()]
    public class EnsembleCrypto : IPersistance
    {
        public ObservableCollection<Crypto> LesCryptos { get; set; }

        public EnsembleCrypto()
        {
            LesCryptos = new ObservableCollection<Crypto>();
        }

        public Crypto this[string nom]
        {
            get
            {
                foreach (Crypto c in LesCryptos)
                {
                    if (c.Nom == nom)
                        return c;
                }
                return null;
            }
        }

        public void Sauvegarde()
        {
            List<Crypto> mesCryptos = new List<Crypto>();
            foreach (Crypto c in LesCryptos)
                mesCryptos.Add(c);

            using (Stream stream = File.Open("data.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, mesCryptos);
            }

        }

        public void Chargement()
        {
            if (File.Exists("data.bin"))
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var lizards2 = (List<Crypto>)bin.Deserialize(stream);
                    foreach (Crypto c in lizards2)
                    {
                        //contains implémente equals
                        if (!LesCryptos.Contains(c))
                        {
                            LesCryptos.Add(c);
                        }

                    }
                }
            }
        }
    }
}
