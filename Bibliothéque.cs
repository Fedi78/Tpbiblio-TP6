using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpbiblio
{
    public class Bibliothèque
    {
        public string Nom { get; set; }
        public List<Livre> Livres { get; set; }

        public Bibliothèque(string nom)
        {
            Nom = nom;
            Livres = new List<Livre>();
        }

        public Livre LivreExiste(string titre)
        {
            foreach (Livre livre in Livres)
            {
                if (livre.Titre == titre)
                {
                    return livre;
                }
            }
            return null;
        }

        public void AjouterLivre(Livre livre)
        {
            Livres.Add(livre);
        }

        public int Cardinal()
        {
            return Livres.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bibliothèque: {Nom}");
            sb.AppendLine("Liste des livres:");
            foreach (Livre livre in Livres)
            {
                sb.AppendLine(livre.ToString());
            }
            return sb.ToString();
        }

        public void AfficheParAuteur(string auteur)
        {
            foreach (Livre livre in Livres)
            {
                if (livre.Auteur == auteur)
                {
                    Console.WriteLine(livre.ToString());
                }
            }
        }

        public void AfficheParEditeur(string editeur)
        {
            foreach (Livre livre in Livres)
            {
                if (livre.Editeur == editeur)
                {
                    Console.WriteLine(livre.ToString());
                }
            }
        }

        public bool SupprimerLivre(string titre)
        {
            Livre livre = LivreExiste(titre);
            if (livre != null)
            {
                Livres.Remove(livre);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SupprimeLivreAuteur(string auteur)
        {
            Livres.RemoveAll(livre => livre.Auteur == auteur);
        }
    }

}
