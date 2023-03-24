using Tugas.Kendaraan;

namespace Tugas.Objek
{
    public class Kendaraan1
    {
        public static void Main()
        {
            //Objek Mobil
            Console.WriteLine("Objek Mobil 1");
            Mobil gtr = new Mobil();
            gtr.merek = "Nissan";
            gtr.tipe = "Skyline R32 Nismo";
            gtr.warna = "Putih";
            gtr.kapasitas = 2600;
            gtr.power = 300;
            gtr.torsion = 450;
            gtr.jenis = "Sedan";
            gtr.Tampilkan();
            gtr.Melaju();
            gtr.Transmisi(5);

            Console.WriteLine("\nObjek Mobil 2");
            Mobil s2k = new Mobil("Honda", "S2000", "Hitam", 2000, 250, 370, "Sedan");
            s2k.Tampilkan();
            s2k.Melaju();
            s2k.Transmisi(4);

            //Objek Motor
            Console.WriteLine("\nObjek Motor 1");
            Motor crf = new Motor();
            crf.merek = "Honda";
            crf.tipe = "CRF 1100 Africa Twin";
            crf.warna = "Biru";
            crf.kapasitas = 1100;
            crf.power = 98;
            crf.torsion = 103;
            crf.jenis = "Touring";
            crf.Tampilkan();
            crf.Melaju();
            crf.Transmisi(5);

            Console.WriteLine("\nObjek Motor 2");
            Motor gs = new Motor("BMW", "R1250GS", "Biru", 1250, 136, 143, "Touring");
            gs.Tampilkan();
            gs.Melaju();
            gs.Transmisi(4);

        }
    }
}
