﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pam_métier_simule
{
    class Employe
    {
        public string SS { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public string CodePostal { get; set; }
        public Indemnites Indemnites { get; set; }

        // signature

        public override string ToString()

        {

            return string.Format("Employé[{0},{1},{2},{3},{4},{5}]", SS, Nom, Prenom, Adresse, Ville, CodePostal);

        }

    }
}

