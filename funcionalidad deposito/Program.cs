using System;

namespace funcionalidad_deposito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola esta usando cajero virtual");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                Deposit();
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

        static void Deposit()
        {
            Console.Write("cantidad a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Has depositado {amount:C}.");
        }
    }
}
