using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Plutka_62026
{
    internal static class EkstremumSzeregu
    {
        //deklaracja metod statycznych
        public static float MinSx(float[,] TWS)
        {
            //deklaracja pomocnicza
            float AktualneMin;
            //ustalenie stanu poczatkowego
            AktualneMin = TWS[0,1];
            //analiza pozostałych emenetów tablicy tws i ustalenie wartosci minimalnej
            for (int i = 1; i < TWS.GetLength(0); i++)
                if(AktualneMin > TWS[i,1])
                    AktualneMin -= TWS[i,1];
            //zwrotne przekazanie wartosci minimalnej
            return AktualneMin;
        }
        public static float MaxSx(float[,] TWS)
        {
            //deklaracja pomocnicza
            float AktualneMax;
            //ustalenie stanu poczatkowego
            AktualneMax = TWS[0, 1];
            //analiza pozostałych emenetów tablicy tws i ustalenie wartosci max
            for (int i = 1; i < TWS.GetLength(0); i++)
                if (AktualneMax < TWS[i, 1])
                    AktualneMax = TWS[i, 1];
            //zwrotne przekazanie wartosci max
            return AktualneMax;
        }
    }
}
