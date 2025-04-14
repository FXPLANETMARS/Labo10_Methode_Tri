using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_bulle
{
    internal class MenuPrincipal
    {
        public static Itrier VotreChoix(int choice)
        {
            switch (choice)
            {
                case 1: return new Trie_Bulle();

                case 2: return new Tri_Insertion();

                case 3: return new Tri_Selection();

                case 4: return new Tri_Rapide();

                    //case 5: return new Tri_Fusion();
                
                default:
                    Console.WriteLine("choix invalide");

                    return null ;
            }
        }
    }
}
