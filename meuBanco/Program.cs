using System;

namespace meuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario funcionarioLuciano = new Funcionario();
            funcionarioLuciano.Nome = "Luciano Machado";
            funcionarioLuciano.CPF = "11122233344";
            funcionarioLuciano.Cargo = "Vendedor";
            funcionarioLuciano.Salario = 1000;

            Funcionario funcionarioDouglas = new Funcionario();
            funcionarioDouglas.Nome = "Douglas Bonifacio";
            funcionarioDouglas.CPF = "55566677788";
            funcionarioDouglas.Cargo = "Vendedor";
            funcionarioDouglas.Salario = 1000;
            ContaCorrente contaDaKarol = new ContaCorrente("Karolaine Bonifácio", 1234, 789, 100.50, funcionarioDouglas);
            ContaCorrente contaDoKaique = new ContaCorrente("Kaique Bonifácio", 4321, 987, 120, funcionarioLuciano);
            ContaCorrente contaDaKatlin = new ContaCorrente("Katlin Bonifácio", 4322, 988, 150, funcionarioLuciano);

            contaDaKarol.Conta = 890;
            contaDaKatlin.Conta= 980;
            contaDoKaique.Conta= 809;

            Console.WriteLine("O saldo da conta da Karolaine Bonifácio é: " + contaDaKarol.Saldo +"\nSacando R$100 ");
            contaDaKarol.Sacar(100);
            Console.WriteLine("O saldo da conta da Karolaine Bonifácio é: " + contaDaKarol.Saldo +"\nDepositando R$50 ");
            contaDaKarol.Depositar(50);
            Console.WriteLine("O saldo da conta da Karolaine Bonifácio é: " + contaDaKarol.Saldo);
            Console.WriteLine("O saldo da conta do Katlin Bonifácio é: " + contaDaKatlin.Saldo);
            Console.WriteLine("O saldo da conta do Kaique Bonifácio é: " + contaDoKaique.Saldo + "\nTransferindo R$30 para Katlin Bonifácio");
            contaDoKaique.Transferir(30, contaDaKatlin);
            Console.WriteLine("O saldo da conta do Kaique Bonifácio é: " + contaDoKaique.Saldo);
            Console.WriteLine("O saldo da conta do Katlin Bonifácio é: " + contaDaKatlin.Saldo);

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("O total de comissão a ser paga é: " + ContaCorrente.TotalDeComissao);

            Console.WriteLine("A comissão do vendedor Luciano Machado é: " + funcionarioLuciano.Comissao);
            Console.WriteLine("A comissão do vendedor Douglas Bonifácio é: " + funcionarioDouglas.Comissao);

            Console.WriteLine("O salário do vendedor Luciano Machado é: " + funcionarioLuciano.Salario);
            Console.WriteLine("O salário do vendedor Douglas Bonifácio é: " + funcionarioDouglas.Salario);

        }
    }
}
