using System;

namespace RETIRAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola estas usando cajero virtual");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                Withdraw();
            }
            else
            {
                Console.WriteLine("Inicio de sesión cancelado");
            }
        }

        static bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();
            return username == "ANGEL" && password == "Angel2314#0222";
        }

        static void Withdraw()
        {
            Console.Write("dinero a retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Has retirado {amount:C}.");
        }
    }
}
