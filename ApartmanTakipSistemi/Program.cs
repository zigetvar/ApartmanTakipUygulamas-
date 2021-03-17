using System;

namespace ApartmanTakipSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Personİnformation.İnformation();
                Personİnformation.ReceivedMoney();
                Personİnformation.yapilanİslemler();
                Console.WriteLine("*********************");
                Console.WriteLine("Kayıt İşlemi Bitti Mi? : /e/h ");
                string kontrol = Console.ReadLine();
                if (kontrol=="e")
                {
                    Console.WriteLine("Kayıt İşlemi Tamamlandı...");
                    break;
                   
                }

            }
            Console.ReadLine();

        }
    }
}
