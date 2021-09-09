using System;

namespace meuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKarol = new ContaCorrente("Karol", 1234, 789, 100.50);

            ContaCorrente contaDoKaique = new ContaCorrente("Kaique", 4321, 987, 120);

            ContaCorrente contaDaKatlin = new ContaCorrente("Katlin", 4322, 988, 150);

            Console.WriteLine("O titular da conta é: " +contaDaKarol.titular);
            Console.WriteLine("O titular da conta é: " +contaDoKaique.titular);
            Console.WriteLine("O titular da conta é: " +contaDaKatlin.titular);
        }
    }
}
