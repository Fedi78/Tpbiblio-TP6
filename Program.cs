
namespace tpbiblio
{
    class Program
    {


        static void main(string[] args)
        {


            Bibliothèque bi = new Bibliothèque("Guntenberg");
            bi.AjouterLivre(new Livre("L1", " Quatre vingt treize", 1870, "Dunod"," Victor Hugo"));
            bi.AjouterLivre(new Livre("L2", " Les misérables", 1873, "folio", "Victor Hugo"));
            bi.AjouterLivre(new Livre("L3", " l'ame du mal", 2005, "poche", "Maxime Chatam"));
            bi.AjouterLivre(new Livre("L4", " Desert", 1980, "Folio", "Le clezio"));
            bi.AjouterLivre(new Livre("L5", " Diégo et Frida", 1975, "poche", "Camus"));
            bi.AjouterLivre(new Livre("L6", " L'étranger", 1950, "Folio", "Camus"));


            // Affiche Tout

            Console.WriteLine(bi);
            Console.ReadKey();
            bi.AfficheParAuteur("Victor Hugo");
            Console.ReadKey();
            bi.AfficheParEditeur("poche");
            Console.ReadKey();
            bi.SupprimerLivre("Desert");
            Console.WriteLine(bi);
            Console.ReadKey();
            bi.SupprimeLivreAuteur("Victor Hugo");
            Console.WriteLine(bi);
            Console.ReadKey();
            

        }
   



    }


}