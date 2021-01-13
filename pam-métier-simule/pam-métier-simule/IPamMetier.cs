using System;
using System.Collections.Generic;
using System.Text;

namespace pam_métier_simule
{
    interface IPamMetier
    {
        // liste de toutes les identités des employés 7.//
        Employe[] GetAllIdentitesEmployes();

        // ------- le calcul du salaire//
        FeuilleSalaire GetSalaire(string ss, double heuresTravaillées, int joursTravaillés);
    }
}
