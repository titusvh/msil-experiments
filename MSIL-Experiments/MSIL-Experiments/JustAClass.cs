using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsilExperiments
{
    public class JustAClass
    {
        public void InitArray()
        {
            var arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = 1;
            }
        }

        public int[] GetInitArr()
        {
            var arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = 1;
            }

            return arr;
        }
    }
}
