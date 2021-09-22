public class ContaCorrente{
    public string titular {get; set;}
    public int agencia {get; set;}
    public int conta {get; set;}
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

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo) 
    { 
        titular = contacorrente_titular;
        agencia = contacorrente_agencia;
        saldo = contacorrente_saldo; 
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
