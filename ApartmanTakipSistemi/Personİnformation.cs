using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmanTakipSistemi
{
    static class Personİnformation
    {
        public static void İnformation()
        {
            Console.Write("Kat:");
            string floorNum = Console.ReadLine();
            Console.Write("İsim:");
            string name = Console.ReadLine();
            Console.Write("Soyisim:");
            string surname = Console.ReadLine();
            Console.Write("Yaş:");
            string age = Console.ReadLine();

        }

        public static void ReceivedMoney()
        {
            Console.Write("Alınan para:");
            string received_money = Console.ReadLine();
        }

        public static void yapilanİslemler()
        {
            Console.Write("Yapılan işlemler:");
            string yapilan_islemler = Console.ReadLine();
        }
    }
}
