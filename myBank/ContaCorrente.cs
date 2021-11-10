public class ContaCorrente {

    public string Titular { get; set; }
    public int Agencia { get; set; }
    public int Conta { get; set; }

    public static double TotalDeComissao { get; set; }
    public static int TotalDeContasCriadas { get; set; }

    private double _saldo;

    public double Saldo {
            get{
                return this._saldo;
            }
            set{
                if(value >= 0){
                    this._saldo = value;
                }
            }
    }


    public ContaCorrente(){} 

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, double contacorrente_saldo, Funcionario funcionario)
    {
        
        Titular = contacorrente_titular;
        Agencia = contacorrente_agencia;
        Saldo = contacorrente_saldo;

        TotalDeContasCriadas ++;
        TotalDeComissao += contacorrente_saldo * 0.01;

        funcionario.Comissao += contacorrente_saldo * 0.01;

    }

    public bool Sacar (double valor){ 
        if (this.Saldo < valor){
            return false;
        }
        else {
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor){ 
        this.Saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}