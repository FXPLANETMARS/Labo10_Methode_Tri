using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_bulle
{
    internal class Trie_Bulle:Itrier
    {
        //Compare les éléments adjacents et les échanges s'ils sont dans le mauvais ordre

        public List<int> TrierListe(List<int> list)
        {
            var result = new List<int>(list); // Passage de la liste venue en paramètre
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = 0; j < result.Count - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        (result[j], result[j + 1]) = (result[j + 1], result[j]);
                        //Affectation en tuple (affecter plusieurs valeurs en même temps)

                        //int temp = result[j]
                        //result[j] = result[j+1]
                        //result[j+1] = temp;

                    }
                }
            }
            return result;
        }
    }
}
