using System;
using System.Collections.Generic;
using System.Text;

namespace pam_métier_simule
{
    class ElementsSalaire
    {
        // propriétés automatiques

        public double SalaireBase { get; set; }

        public double CotisationsSociales { get; set; }

        public double IndemnitesEntretien { get; set; }

        public double IndemnitesRepas { get; set; }
        public double SalaireNet { get; set; }



        // ToString

        public override string ToString()

        {

            return string.Format("[{0} : {1} : {2} : {3} : {4} ]", SalaireBase, CotisationsSociales, IndemnitesEntretien, IndemnitesRepas, SalaireNet);

        }
    }
}
