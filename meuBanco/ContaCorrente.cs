public class ContaCorrente{
    public string Titular {get; set;}
    public int Agencia {get; set;}
    public int Conta {get; set;}
    
    public static int TotalDeContasCriadas {get; set;}
    public static double TotalDeComissao {get; set;}

    private double saldo;

    public double Saldo
    {
        get
        {
            return this.saldo;
        }
        set
        {
            if (value >= 0)
            {
                this.saldo = value;
            }
        }
    }

    public ContaCorrente() {}

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo, Funcionario funcionario) 
    { 
        Titular = contacorrente_titular;
        Agencia = contacorrente_agencia;
        saldo = contacorrente_saldo; 

        TotalDeContasCriadas ++;
        TotalDeComissao += contacorrente_saldo * 0.01;

        funcionario.Comissao += contacorrente_saldo * 0.01;
    } 

    public bool Sacar (double valor)
    { 
        if(this.saldo < valor)
        { 
            return false; 
        } 
        else
        { 
            this.saldo -= valor; 
            return true; 
        } 
    }

    public void Depositar (double valor)
    { 
        this.saldo += valor; 
    } 
        
    public bool Transferir (double valor, ContaCorrente contaDestino)
    {     
        if (this.saldo < valor)
        { 
            return false; 
        }

        else
        { 
            this.Sacar(valor); 
            contaDestino.Depositar(valor); 
            return true; 
        } 
    } 
}
