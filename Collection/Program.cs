using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan_tetap karyawantetap = new Karyawan_tetap();

            karyawantetap.nik = "19.11.2713";
            karyawantetap.nama = "alfandi setiawan";
            karyawantetap.gaji_bulanan = 3000000;

            Karyawan_harian karyawanharian = new Karyawan_harian();

            karyawanharian.nik = "444-555-666";
            karyawanharian.nama = "hasrianto";
            karyawanharian.jumlah_jamkerja = 45;
            karyawanharian.upah_perjam = 35000;

            Sales sales = new Sales();
            
            sales.nik = "777-888-999";
            sales.nama = "pranata";
            sales.jumlah_penjualan = 27;
            sales.komisi = 40000;


            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int nomor = 1;
            
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine();
                Console.WriteLine("{0}.Nama\t: {1}   ,NIK\t: {2}   ,Gaji\t: {3:N0}",nomor,karyawan.nama,karyawan.nik,karyawan.Gaji);
                nomor++;
            }

            Console.ReadKey();
        }
    }
}