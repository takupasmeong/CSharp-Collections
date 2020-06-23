using System;
using System.Collections.Generic;
using collections.classInduk;
using collections.classAnak;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawanTetap karyawanTetap = new karyawanTetap();
            karyawanTetap.Nik = "19.11.2770";
            karyawanTetap.Nama = "Abiyu";
            karyawanTetap.GajiBulanan = 7000000;

            karyawanHarian karyawanHarian = new karyawanHarian();
            karyawanHarian.Nik = "19.11.7270";
            karyawanHarian.Nama = "Putra";
            karyawanHarian.JumlahJamKerja = 12;
            karyawanHarian.UpahPerJam = 50000;

            sales sales = new sales();
            sales.Nik = "19.11.2077";
            sales.Nama = "Aronggear";
            sales.JumlahPenjualan = 100;
            sales.Komisi = 100000;

            List<karyawan> listKaryawan = new List<karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach(karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
            }
        }
    }
}
