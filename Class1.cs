using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public string nim { get; set; }
        public string nama { get; set; }
        public string Kelamin { get; set; }
        public string total { get; set; }

        // public void tambah(){
        //     Console.Write("\nNota: ");
        //     penjualan.nota = nota = Console.ReadLine();
        //     Console.Write("\nTanggal: ");
        //     penjualan.tanggal = tanggal = Console.ReadLine();
        //     Console.Write("\nCustomer : ");
        //     penjualan.nama = nama = Console.ReadLine();
        //     Console.Write("\nJenis : ");
        //     penjualan.jenis = jenis = Console.ReadLine();
        //     Console.Write("\nTotal : ");
        //     penjualan.total = total = Console.ReadLine();

        //     daftarPenjualan.Add(penjualan);
        // }

        // public void tampil(){
        //     Console.WriteLine("\nData Penjualan");
        //     foreach(Penjualan penjual in list){
        //         Console.WriteLine("1. {0}, {1}, {2}, {3}, {4}, {5}",penjual.nota,penjual.tanggal,penjual.nama,penjual.jenis,penjual.total);
        //         Console.WriteLine("\n");
        //     }
        // }
    }
}