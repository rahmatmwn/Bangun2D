using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bangun2D panggil;
            char pilihan;
            string lagi = "";
            //int sisi,panjang, lebar, luas_persegi, luas_Ppanjang;
            //int alas, tinggi;
            //double phi = 3.14 ,r, luas_lingkaran, luas_segitiga;

            do
            {
                Console.WriteLine("========= Perhitungan Luas ==========");
                Console.WriteLine("1. Lingkaran");
                Console.WriteLine("2. Segitiga");
                Console.WriteLine("3. Persegi");
                Console.WriteLine("4. Pergegi Panjang");
                Console.WriteLine("=====================================");
                Console.Write("Pilihanmu : ");
                pilihan = Convert.ToChar(Console.ReadLine());
                switch (pilihan)
                {
                    case '1':
                        /*Console.WriteLine("Lingkaran");
                        Console.Write("Masukkan jari-jari :");
                        r = Convert.ToDouble(Console.ReadLine());
                        luas_lingkaran = phi * r * r;
                        Console.WriteLine("Luas : " + luas_lingkaran.ToString());*/

                        Console.Write("Masukkan nilai jari-jari : ");
                        double jari = Convert.ToDouble(Console.ReadLine());
                        panggil = new Lingkaran(jari);
                        panggil.CetakLuas("Lingkaran");
                        Console.Write("Kembali ke menu? (y/n) : ");
                        lagi = Console.ReadLine();
                        break;
                    case '2':
                        /* Console.WriteLine("Segitiga");
                         Console.Write("Masukkan Alas :");
                         alas = Convert.ToInt16(Console.ReadLine());
                         Console.Write("Masukkan Tinggi :");
                         tinggi = Convert.ToInt16(Console.ReadLine());
                         luas_segitiga = 0.5 * alas * tinggi;
                         Console.WriteLine("Luas : " + luas_segitiga.ToString());*/
                        Console.Write("Masukkan nilai alas : ");
                        double alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan nilai tinggi : ");
                        double tinggi = Convert.ToDouble(Console.ReadLine());
                        panggil = new Segitiga(alas, tinggi);
                        panggil.CetakLuas("Segitiga");
                        Console.Write("Kembali ke menu? (y/n) : ");
                        lagi = Console.ReadLine();
                        break;
                    case '3':
                        //Console.WriteLine("Persegi");
                        //Console.Write("Masukkan Sisi :");
                        //sisi = Convert.ToInt16(Console.ReadLine());
                        //luas_persegi = sisi * sisi;
                        //Console.WriteLine("Luas : " + luas_persegi.ToString());

                        Console.Write("Masukkan nilai sisi : ");
                        double sisi = Convert.ToDouble(Console.ReadLine());
                        panggil = new Persegi(sisi);
                        panggil.CetakLuas("Persegi");
                        Console.Write("Kembali ke menu? (y/n) : ");
                        lagi = Console.ReadLine();
                        break;
                    case '4':
                        //Console.WriteLine("Persegi Panjang");
                        //Console.Write("Masukkan Panjang :");
                        //panjang = Convert.ToInt16(Console.ReadLine());
                        //Console.Write("Masukkan Lebar :");
                        //lebar = Convert.ToInt16(Console.ReadLine());
                        //luas_Ppanjang = panjang * lebar;
                        //Console.WriteLine("Luas : " + luas_Ppanjang.ToString());

                        Console.Write("Masukkan nilai panjang : ");
                        double panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan nilai lebar : ");
                        double lebar = Convert.ToDouble(Console.ReadLine());
                        panggil = new PersegiPanjang(panjang, lebar);
                        panggil.CetakLuas("Persegi Panjang");
                        Console.Write("Kembali ke menu? (y/n) : ");
                        lagi = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Your Choice is not found, try again see you later good bye.");
                        Console.Write("Kembali ke menu? (y/n) : ");
                        lagi = Console.ReadLine();
                        break;
                }
                } while (lagi == "y") ;

        }
    }
}
