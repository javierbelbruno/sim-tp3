using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Distribucion
    {
        private static int n;
        private static double[] vRND, vGen;
        private static Random rnd;

        /**
         * Genera 'n' valores aleatorios entre un rango [a,b] con una distribucion
         * de tipo uniforme
         *
         * @param n cantidad de valores aleatorios a generar
         * @param a valor minimo del rango de valores a considerar
         * @param b valor maximo del rango de valores a considerar
         * @return los 'n' valores aleatorios de la distribucion
         */
        public static double[] generarUniforme(int n, int a, int b)
        {
            rnd = new Random();
            vGen = new double[n];
            for (int i = 0; i < n; i++)
            {
                vGen[i] = rnd.Next() * (b - a) + a;
            }
            return vGen;
        }

        /**
         * Genera 'n' valores aleatorios con una distribucion de tipo exponencial
         *
         * @param n cantidad de valores aleatorios a generar
         * @param lamda valor de lamda (media)
         * @return los 'n' valores aleatorios de la distribucion
         */
        public static double[] generarExponencial(int n, double lamda)
        {
            rnd = new Random();
            vGen = new double[n];
            for (int i = 0; i < n; i++)
            {
                vGen[i] = -(1 - rnd.Next()) / lamda;
            }
            return vGen;
        }

        /**
         * Genera 'n' valores aleatorios con una distribucion de tipo normal usando
         * el metodo de convolucion
         *
         * @param n cantidad de valores aleatorios a generar
         * @param media valor de la media (lamda)
         * @param desviacion valor de la desviacion estandar
         * @return los 'n' valores aleatorios de la distribucion
         */
        public static double[] generarNormal(int n, double media, double desviacion)
        {
            rnd = new Random();
            vGen = new double[n];

            for (int i = 0; i < n; i++)
            {
                vGen[i] = (rnd.Next() - 6) * desviacion + media;
            }
            return vGen;
        }

        /**
         * Genera 'n' valores aleatorios con una distribucion de tipo poisson
         * 
         * @param n cantidad de valores aleatorios a generar
         * @param lamda valor de la media
         * @return los 'n' valores aleatorios de la distribucion
         */
        public static double[] generarPoisson(int n, double lamda)
        {
            rnd = new Random();
            vGen = new double[n];
            for(int i = 0; i < n; i++)
            {
                double p = 1;
                double x = -1;
                do
                {
                    p = p * rnd.Next();
                    x++;
                } while (p >= Math.Exp(lamda));
            }            
            return vGen;
        }
    }
}
