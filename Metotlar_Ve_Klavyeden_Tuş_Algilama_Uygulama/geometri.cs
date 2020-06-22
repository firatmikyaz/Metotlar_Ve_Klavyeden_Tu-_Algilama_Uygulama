using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_Ve_Klavyeden_Tuş_Algilama_Uygulama
{
    class geometri
    {
        public static double kuphacimhesaplamametodu(double kupunkenarimetot)
        {
            kupunkenarimetot = Math.Pow(kupunkenarimetot, 3);
            return (kupunkenarimetot);
        }
        public static double konihacimhesaplamametodu(double koniyaricapmetot,double koniyukseklikmetot)
        {
            const double pi = 3.14;
            double konihacimmetot = (pi * Math.Pow(koniyaricapmetot, 2) * koniyukseklikmetot) / 3;
            return (konihacimmetot);
        }
        public static double silindirhacmihesaplamametodu(double silindiryaricapmetot,double silindiryukseklik)
        {
            const double pi = 3.14;
            double silindirhacimmetot = (pi * Math.Pow(silindiryaricapmetot, 2) * silindiryukseklik);
            return (silindirhacimmetot);
        }
    }
}
