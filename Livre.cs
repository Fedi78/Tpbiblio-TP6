using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpbiblio
{
    public class Livre
    {
        private string code;
        private string titre;
        private int annee;
        private string editeur;
        private string auteur;

        public Livre(string co, string ti, int an, string ed, string aut)
        {
            code = co;
            titre = ti;
            annee = an;
            editeur = ed;
            auteur = aut;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public override string ToString()
        {
            return "Code: " + code + "\nTitre: " + titre + "\nAnnée: " + annee + "\nÉditeur: " + editeur + "\nAuteur: " + auteur;
        }
    }

}
