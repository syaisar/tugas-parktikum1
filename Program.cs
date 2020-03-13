using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");


            Console.Write("Masukan Menu pilihan Operator [1, 2, 3, 4]:");
            int angka1;
            int angka2;
            int total = 0;
            int pilihan = Int32.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.Write("Masukan Nilai Angka A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Angka B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a + b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 2)
            {
                Console.Write("Masukan Nilai Angka A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Angka B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a - b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 3)
            {
                Console.Write("Masukan Nilai Angka A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Angka B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a * b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 4)
            {
                Console.Write("Masukan Nilai Angka A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Angka B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a / b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else
            {
                Console.WriteLine("Maaf Pilihan Anda Tidak Ada");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }
    }
}