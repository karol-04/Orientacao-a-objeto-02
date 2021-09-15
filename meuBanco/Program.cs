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

            bool retorno = contaDaKarol.Sacar(50);
            //Console.WriteLine(retorno);
            Console.WriteLine("O saldo da conta da Karol é: " + contaDaKarol.saldo);

            contaDaKarol.Depositar(150);
            Console.WriteLine("O saldo da conta da Karol é: " + contaDaKarol.saldo);

            contaDaKarol.Transferir(50, contaDoKaique);
            Console.WriteLine("O saldo da conta da Karol é: " + contaDaKarol.saldo);
            Console.WriteLine("O saldo da conta do Kaique é: " + contaDoKaique.saldo);

        }
    }
}
