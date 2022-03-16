using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_1
{
    class Program
    {
        //deklarasi variabel dengan tipe data double
        double angka;

        //membuat method cekbilangan()
        public void cekbilangan()
        {
            //menampilkan string "Nasukkan jumlah bilangan yang akan dicari genap dan ganjilnya:"
            Console.Write("Masukkan jumlah bilangan yang akan dicari genap dan ganjilnya: ");

            //membaca input user dan mengubah tipe datanya menjadi double
            angka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("=========================================");
            Console.WriteLine("Hasil Pencarian Bilangan Ganjil dan Genap");
            Console.WriteLine("=========================================");
            Console.WriteLine("");

            //membuat perulangan "for" dimulai dengan value dari i=0, sampai
            //dengan i <= input dari user
            for (int i = 1; i <= angka; i++)
            {
                //membuat decision making untuk menetukan modulus
                if (1 % 2 == 0)
                {
                    Console.Write("\nBilangan (0) adalah merupakan bilangan genap ", i);
                }
                else
                {
                    Console.Write("nBilangan (0) adalah merupakan bilangan ganjil ", i);
                }
            }
        }
        static void Main(string[] args)
        {
            //deklarasi variabel "jawaban" dengan tipe data string
            string jawaban;

            //deklarasi variabel "ulang" dengan tipe data int
            int ulang;

            //membuat objek baru dari class program
            Program p = new Program();

            //memanggil method cekbilangan() dari class program
            p.cekbilangan();

            Console.WriteLine("\n");
            Console.WriteLine("Apakah ingin mencoba mencari bilangan ganjil dan genap lagi ? ");

            //memberikan value untuk variabel "jawaban" dari input user
            jawaban = Console.ReadLine();

            //nembuat kondisi apakah input user berupa karakter 'y' atau y
            if (jawaban.Equals("y") || jawaban.Equals("Y"))
            {
                Console.WriteLine("Berapa kali anda ingin mengulang pencarian bilangan genap ? ");

                //membaca input user dan mengubah tipe datanya menjadi int
                ulang = Convert.ToInt32(Console.ReadLine());

                //membuat perulangan untuk mengulang mencari bilangan genap sebanyak yang diinput user
                while (ulang > 0)
                {
                    //memanggil method cekbilangan() dari class program
                    p.cekbilangan();
                    Console.WriteLine("\n");

                    //decrement 1
                    ulang--;
                }
                Console.ReadKey();
            }
        }
    }
}
