using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bub
{
    class sorttArray
    {
        static void Main(string[] args)
        {
            double[,] mar = new double[3, 5] { { 1, 3, 0, 7, 5 }, { 2, -4, 6, 0, 1 }, { 3, 1, 4, 2, 5 } };
            
            double[] ar = new double[15];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                double[] ar1= new double[5];
               
                for (int j = 0; j < 5; j++)
                {
                    ar1[j] = mar[i, j];

                 

                }
                ar1 = sortArray(ar1);
                
                for (int t= 0; t < 5; t++)
                {
                   
                    ar[count] = ar1[t];
                    Console.Write(ar1[t]+"  ");
                    
                    count++;
                }
                Console.WriteLine();

            }
            ar = sortArray(ar);
            for (int i = 0; i < 15; i++)
            {
                Console.Write(ar[i]);
            }
            Console.ReadKey();
          

        double[] sortArray(double[] aar)
            {
               

                double num;

                for (int i = 0; i < aar.Length - 1; i++)

                    for (int j = i + 1; j < aar.Length; j++)


                        if (aar[i] > aar[j])
                        {

                            num = aar[i];
                            aar[i] = aar[j];
                            aar[j] = num;
                        }

                return aar;
               
            }
            
           
        }
    }
}


