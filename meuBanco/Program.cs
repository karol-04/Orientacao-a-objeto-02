using System;

namespace meuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKarol = new ContaCorrente();

            contaDaKarol.titular = "Karol";
            contaDaKarol.agencia = 1234;
            contaDaKarol.conta = 789;
            contaDaKarol.saldo = 100.50;

            ContaCorrente contaDoKaique = new ContaCorrente();

            contaDoKaique.titular = "Kaique";
            contaDoKaique.agencia = 4321;
            contaDoKaique.conta = 987;
            contaDoKaique.saldo = 100.50;

            Console.WriteLine("O titular da conta é: " +contaDaKarol.titular);
            Console.WriteLine("O titular da conta é: " +contaDoKaique.titular);
        }
    }
}
