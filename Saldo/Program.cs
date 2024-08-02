using System;

namespace Saldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola esta usando cajero virtual");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                CheckBalance();
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

        static void CheckBalance()
        {
            decimal balance = 1000.00m; 
            Console.WriteLine($"Su saldo actual es {balance:C}.");
        }
    }
}
