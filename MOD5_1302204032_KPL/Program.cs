using System;

namespace GenericExample
{
    // Membuat class HaloGeneric
    public class HaloGeneric
    {
        // Method dengan generic parameter
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }

        // Method utama (main) untuk memanggil SapaUser
        public static void Main(string[] args)
        {
            // Membuat objek dari class HaloGeneric
            HaloGeneric halo = new HaloGeneric();

            // Memanggil method SapaUser dengan input nama praktikan
            halo.SapaUser("Alwin Fahrozi Marbun");
        }
    }
}
