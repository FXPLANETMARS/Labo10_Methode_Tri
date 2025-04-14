using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_bulle
{
    internal class Tri_Insertion:Itrier
    {
        public List<int> TrierListe(List<int> list)
        {
            var result = new List<int>(list);
            for (int i = 1; i < result.Count; i++)
            {
                int tempon = result[i];
                int j = i - 1;
                while (j >= 0 && result[j] > tempon)
                {

                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = tempon;
            }
            return result;
        }
    }
}
