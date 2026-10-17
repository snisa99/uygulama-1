using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Kaç günlüğüne ekipman istiyorsunuz? ");
                string giris = Console.ReadLine();

                if (!int.TryParse(giris, out int gun))
                {
                    Console.WriteLine("Talep reddedildi: Sayısal bir değer giriniz.");
                }
                else if (gun < 1 || gun > 7)
                {
                    Console.WriteLine("Talep reddedildi: Gün sayısı 1 ile 7 arasında olmalıdır.");
                }
                else
                {
                    Console.Write("Ekipman ödünçte mi? (evet/hayır): ");
                    string odunc = Console.ReadLine().ToLower();

                    if (odunc == "evet")
                    {
                        Console.WriteLine("Talep reddedildi: Ekipman ödünçte.");
                    }
                    else if (odunc == "hayır")
                    {
                        Console.WriteLine("Talep kabul edildi!");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ekipman durumu.");
                    }
                }
            
        }
    }
    
}
