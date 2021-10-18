using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    class Metodos
    {
        public void QuickSort(int[] a, int p, int r)
        {
            int i, j, k, pivo;
            pivo = a[(p + r) / 2];
            i = p;
            j = r;
            while(i <= j)
            {
                while( a[i] < pivo)
                    i++;
                while (a[j] > pivo)
                    j--; 
                if (i <= j)
                {
                    k = a[i];
                    a[i] = a[j];
                    a[j] = k;
                    i=i+1;
                    j=j+1;
                }
            }
            if(j > p)
                QuickSort(a, p, j);
            if(i < r)
                QuickSort(a, i, r);
        }
    }
}
