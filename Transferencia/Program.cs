using System;

namespace Transferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola esta usando cajero virtual");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                Transfer();
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
            Console.ReadKey();
        }

        static void Transfer()
        {
            Console.Write("cantidad a transferir: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta destinatario: ");
            string accountNumber = Console.ReadLine();
            Console.WriteLine($"Has transferido {amount:C} a la cuenta {accountNumber}.");
            Console.ReadKey();
        }
    }
}
