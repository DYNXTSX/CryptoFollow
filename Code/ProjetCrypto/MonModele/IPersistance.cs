using System;
using System.Collections.Generic;
using System.Text;

namespace MonModele
{
    interface IPersistance
    {
        void Sauvegarde();
        void Chargement();
    }
}
