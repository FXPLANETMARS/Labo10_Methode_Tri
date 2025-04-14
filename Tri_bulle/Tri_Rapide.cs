using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_bulle
{
    internal class Tri_Rapide : Itrier
    {
        public List<int> TrierListe(List<int> list)
        {
            var result = new List<int>(list);
            TrierRapide(result, 0, result.Count - 1);
            return result;
        }

        private void TrierRapide(List<int> list, int gauche, int droite)
        {
            if (gauche < droite)
            {
                int pivot = Partitioner(list, gauche, droite);
                TrierRapide(list, gauche, pivot - 1);
                TrierRapide(list, pivot - 1, droite);
            }
        }

        private int Partitioner(List<int> list, int gauche, int droite)
        {
            throw new NotImplementedException();
        }
    }
}
