using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
        {
            public static void Main()
            {
            Mobil mobil1 = new Mobil();
            
            mobil1.Warna = "Putih";
            mobil1.JumlahPintu = 4;
            mobil1.Merk = "Honda";
            mobil1.Model = "Civic Turbo";
            mobil1.TahunKeluar = 2021;
            
            mobil1.Gas(230);
            mobil1.Klakson("tiiin");
            mobil1.Tampilkaninfo();



            Console.Write("Press <R> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.R) { }
        }
        }

       

        }
 
