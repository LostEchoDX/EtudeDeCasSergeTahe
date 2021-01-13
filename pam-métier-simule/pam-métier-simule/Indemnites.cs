using System;
using System.Collections.Generic;
using System.Text;

namespace pam_métier_simule
{
    class Indemnites
    {
        public int Indice { get; set; }

        public double BaseHeure { get; set; }

        public double EntretienJour { get; set; }

        public double RepasJour { get; set; }

        public double IndemnitesCp { get; set; }

        // signature

        public override string ToString()
        {
            return string.Format("Indemnités[{0},{1},{2},{3},{4}]", Indice, BaseHeure, EntretienJour, RepasJour, IndemnitesCp);
        }

    }

}
