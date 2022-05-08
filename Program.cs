using System.Globalization;

namespace DataOut
{
     class Program
    {

        public static void Main(string[] args)
        {
            //saída de dados 
            // string name = "Jorge";
            // string surname = "Vicente";
            // char gender = 'M';
            // int age = 16;
            // double balance = 256.45688;

            // Console.Write("Olá, {0} {1},", name, surname);
            // Console.WriteLine($"você tem {age} anos / sexo {gender}");
            // Console.WriteLine("Você possui " + balance.ToString("F2") + " em sua conta bancária.");

            Console.Write("Quanto dinheiro você possui?");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você possui {money} reais.");
            Console.WriteLine();
            Console.Write("Digite um valor para somar ao seu saldo: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            money += deposit;
            Console.WriteLine($"{deposit} reais somados! Agora você possui {money} reais.");
        }
    }
}   
   