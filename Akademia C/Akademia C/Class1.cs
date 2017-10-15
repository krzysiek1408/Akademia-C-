using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia_C
{
    class Helpful
    {
        public int[] Randomize(int n, int i)    //n - rozmiar tablicy, i-kraj dla poprawnej odpowiedzi
        {
            int[] Array = new int[n];
            for (int w = 0; w < n; w++)
            {
                Array[w] = i;
            }
            Random rand = new Random();
            //int Temp = rand.Next(n);
            int Temp;
            //Array[Temp] = i;
            for(int w=0; w<n-1; w++)
            {
                int Temp2 = rand.Next(n);
                if (Array[Temp2] != i)
                    w--;
                else
                {
                    Temp = rand.Next(10);
                    int Condition = 0;

                    for(int c=0; c<n;c++)
                    {
                        if(Array[c]==Temp)
                        {
                            Condition = 1;
                            w--;
                        }
                    }

                    if (Condition == 0)
                    { Array[Temp2] = Temp; }
                }
            }

            return Array;
        }
        

    }
}
