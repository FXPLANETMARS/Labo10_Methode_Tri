namespace Tri_bulle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez les données de la liste( ex: 8 3 7 1 17)");
            var input = Console.ReadLine();

            var data = input.Split(' ').Select(int.Parse).ToList();

            /*input.Split(' ') => sous-chaine, en utilisant l'espace comme delimiteur
             on obtient une sous-chaine["8", "3","7",...]
            Select(int.Parse)=> Convertir une chaine de caractère en entier. le faire sur chaque élément ex: "8"=>8
            ToList()=> Convertir la séquence d'entier en une liste d'entier; [8,3,7,...]*/

            Console.WriteLine("\nChoisissez un algorithme de tri");
            Console.WriteLine("1. Tri Bulle");
            Console.WriteLine("2. Tri Insertion");
            Console.WriteLine("3. Tri Selection");
            Console.WriteLine("4. Tri Rapide");
            Console.WriteLine("5. Tri Fusion");

            Console.Write("\nVotre choix(1-5) : ");
            int choix = int.Parse(Console.ReadLine());

            Itrier algorithme = MenuPrincipal.VotreChoix(choix);
            List<int> ListeTrier = algorithme.TrierListe(data);

            Console.WriteLine("\nListe triée:");
            Console.WriteLine(string.Join(" ", ListeTrier));

        }
    }
}
