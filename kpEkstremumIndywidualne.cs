using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Plutka_62026
{
    internal class kpEkstremumIndywidualne
    {
        public static float kpMinSx(float[,] kpTWS)
        {
            float kpAktualneMin;
            kpAktualneMin = kpTWS[0, 1];
            for (int i = 0; i < kpTWS.GetLength(0); i++)
                if (kpAktualneMin > kpTWS[i, 1])
                    kpAktualneMin = kpTWS[i, 1];
            return kpAktualneMin;
        }
        public static float kpMaxSx(float[,] kpTWS)
        {
            float kpAktualneMax;
            kpAktualneMax = kpTWS[0, 1];
            for (int i = 0; i < kpTWS.GetLength(0); i++)
                if (kpAktualneMax < kpTWS[i, 1])
                    kpAktualneMax = kpTWS[i, 1];
            return kpAktualneMax;
        }
    }
}
