using System;
using System.Collections.Generic;
using System.Text;

namespace pam_métier_simule
{
    class FeuilleSalaire
    {
        // propriétés automatiques

        public Employe Employe { get; set; }

        public Cotisations Cotisations { get; set; }
        public ElementsSalaire ElementsSalaire { get; set; }

        // ToString

        public override string ToString()
        {

            return string.Format("[{0},{1},{2}]", Employe, Cotisations, ElementsSalaire);

        }
    }
}
