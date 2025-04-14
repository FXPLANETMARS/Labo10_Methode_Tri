using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_bulle
{
    internal class Tri_Selection : Itrier
    {
        //Trouve le plus petit élément et le place au début

        public List<int> TrierListe(List<int> liste)
        {
            var result = new List<int>(liste);
            for (int i = 0; i < result.Count - 1; i++)
            {
                int minElement = i;
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (result[j] < result[minElement])
                    {
                        minElement = j;
                    }
                }
                (result[i], result[minElement]) = (result[minElement], result[i]);

            }
            return result;
        }
    }
}
