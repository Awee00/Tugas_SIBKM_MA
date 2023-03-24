namespace Tugas.Kendaraan
{
    public abstract class AbstractKendaraan
    {
        public string merek, tipe, warna;
        public int kapasitas, power, torsion;

        public abstract void Melaju();

        public abstract void Transmisi(int gear);
    }
}
