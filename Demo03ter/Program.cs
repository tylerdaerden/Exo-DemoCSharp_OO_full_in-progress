internal class Program
{
    static void Main (string[] args)
    {

        Panier thierry = new Panier();
        thierry.Ajouter("Coca");
        thierry.Ajouter("Chips");
        thierry.Ajouter("Pellet");

        Panier compagne = new Panier();
        thierry.Ajouter("Viande");
        thierry.Ajouter("fruits");
        thierry.Ajouter("rhum");

        Panier total = thierry + compagne;

        // ce que nous voulons faire 
        //Panier = Panier + Panier
        //Panier operator + (Panier? p1 , Panier p2)

    }

    class Panier
    {
        public static Panier operator +(Panier? a, Panier? b)
        {
            if (a is null && b is null)
                return new Panier();

            if (a is null && b is not null)
                return b;

            if (a is not null && b is null)
                return a;

            Panier panier = new Panier();
            panier.article.AddRange(a.article);
            panier.article.AddRange(b.article);
            return panier;
        }

        private List<string> article = new List<string>();

        public void Ajouter(string ArticleNom)
        {
            article.Add(ArticleNom);
        }
    }

}