using System;
using System.Collections.Generic;
using System.Text;

namespace pam_dao
{
    interface IpamDao
    {
        //liste de toutes les idendités des employés
        Employe[] GetAllIdentitesEmployes();

        //un employé particulier avec ses indemnités

        Employe GetEmploye(string ss);

        //liste de toutes les cotisations

        Cotisations GetCotisations();
    }
}
