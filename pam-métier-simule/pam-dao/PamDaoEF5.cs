using System;
using System.Collections.Generic;
using System.Text;

namespace pam_dao
{
    class PamDaoEF5 : IpamDao
    {
        // champs privés

        private Cotisations cotisations;
        private Employe[] employes;

        // Constructeur

        public PamDaoEF5()

        {

            // cotisation

            try
            {


            }

            catch (Exception e)

            {
                throw new PamException("Erreur système lors de la construction de la couche [DAO]", e, 1);

            }

        }


        // GetCotisations

        public Cotisations GetCotisations()

        {

            return cotisations;

        }


        // GetAllIdentitesEmploye

        public Employe[] GetAllIdentitesEmployes()

        {

            return employes;

        }


        // GetEmploye

        public Employe GetEmploye(string SS)

        {

            try
            {

            }
            catch (Exception e)

            {

                throw new PamException(string.Format("Erreur système lors de la recherche de l'employé [{0}]", SS), e, 2);
            }

        }
    }
}

