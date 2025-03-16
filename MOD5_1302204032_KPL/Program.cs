using System;

namespace GenericExample
{
    public class DataGeneric<T>
    {
        // Property data bertipe generic T
        private T data;

        // Konstruktor dengan parameter data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method PrintData untuk mencetak data
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    public class HaloGeneric
    {
        // Method dengan generic parameter
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek dari class HaloGeneric
            HaloGeneric halo = new HaloGeneric();
            // Memanggil method SapaUser dengan input nama praktikan
            halo.SapaUser("Alwin Fahrozi Marbun");

            // Menambahkan contoh penggunaan DataGeneric
            string nim = "1302204032"; // Ganti dengan NIM Anda
            DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);
            dataGeneric.PrintData();
        }
    }
}
