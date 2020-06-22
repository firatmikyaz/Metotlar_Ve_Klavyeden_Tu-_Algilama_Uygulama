using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_Ve_Klavyeden_Tuş_Algilama_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tusbilgisi;
            do
            {
                Console.Clear();
                Console.WriteLine("CTRL+K: Küp Hacmi");
                Console.WriteLine("ALT+O: Koni Hacmi");
                Console.WriteLine("SHIFT+A: Silindir Hacmi");
                Console.WriteLine("Seçiminizi yapınız?");
                Console.WriteLine("ESC programdan çıkmanızı sağlar..");

                tusbilgisi = Console.ReadKey();
                if ((tusbilgisi.Modifiers & ConsoleModifiers.Control)!=0)
                {
                    if (tusbilgisi.Key.ToString()=="K")
                    {
                        Console.WriteLine("Küpün bir kenarını giriniz?");
                        double kupkenar = Convert.ToDouble(Console.ReadLine());
                        double kupsonuc = geometri.kuphacimhesaplamametodu(kupkenar);
                        Console.WriteLine("Küpün Hacmi: {0}", kupsonuc);
                    }
                }
                else if ((tusbilgisi.Modifiers & ConsoleModifiers.Alt)!=0)
                {
                    if (tusbilgisi.Key.ToString()=="O")
                    {
                        Console.WriteLine("Koni yarıçap değerini giriniz?");
                        double koniyaricap = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Koni yükseklik değerini giriniz?");
                        double koniyukseklik = Convert.ToDouble(Console.ReadLine());
                        double konisonuc = geometri.konihacimhesaplamametodu(koniyaricap, koniyukseklik);
                        Console.WriteLine("Koni Hacmi: {0}", konisonuc);
                    }
                }
                else if ((tusbilgisi.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    if (tusbilgisi.Key.ToString() == "A")
                    {
                        Console.WriteLine("Silindir yarıçap değerini giriniz?");
                        double silindiryaricap = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Silindir yükseklik değerini giriniz?");
                        double silindiryukseklik = Convert.ToDouble(Console.ReadLine());
                        double silindirsonuc = geometri.silindirhacmihesaplamametodu(silindiryaricap, silindiryukseklik);
                        Console.WriteLine("Silindir Hacmi: {0}", silindirsonuc);
                    }
                }

            } while (Console.ReadKey().Key.ToString()!="Escape");
        }
    }
}
