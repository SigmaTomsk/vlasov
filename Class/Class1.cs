using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Class2
    {
        public int plus(int[] a)
        {
            int rez = 0;
            for (int i = 0; i < a.Length; i++)
            {
                rez += a[i];

            }
            return rez;
        }

    }
    
}
