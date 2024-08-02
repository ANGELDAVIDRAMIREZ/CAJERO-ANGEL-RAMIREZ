using System;

namespace sesion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola bienvenido al cajero");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión completado");
            }
            else
            {
                Console.WriteLine("Inicio de sesión cancelado");
            }
        }

        static bool Login()
        {
            Console.Write("Digite su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Digite su contraseña: ");
            string password = Console.ReadLine();

            return username == "ANGEL" && password == "Angel2314#0222"; 
        }
    }
}
