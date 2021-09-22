using System;

namespace meuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKarol = new ContaCorrente("Karol", 1234, 789, 100.50);
            
            contaDaKarol.conta = 890;

            ContaCorrente contaDoKaique = new ContaCorrente("Kaique", 4321, 987, 120);

            ContaCorrente contaDaKatlin = new ContaCorrente("Katlin", 4322, 988, 150);

            contaDaKarol.Sacar(100);

            /*Console.WriteLine("O titular da conta é: " +contaDaKarol.titular);
            Console.WriteLine("O titular da conta é: " +contaDoKaique.titular);
            Console.WriteLine("O titular da conta é: " +contaDaKatlin.titular);

            contaDaKarol.Depositar(150);
            contaDaKarol.Transferir(50, contaDoKaique);*/

            Console.WriteLine("O número da conta da Karol é: "+ contaDaKarol.conta);
            Console.WriteLine("O saldo da conta da Karol é: " + contaDaKarol.saldo);
            Console.WriteLine("O número da conta do Kaique é: " + contaDoKaique.conta);
            Console.WriteLine("O saldo da conta do Kaique é: " + contaDoKaique.saldo);

        }
    }
}
