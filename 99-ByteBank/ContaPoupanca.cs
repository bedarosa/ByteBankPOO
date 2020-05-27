public class ContaPoupanca
{
    public string titular;
    public int agencia;
    public double saldo;

    public bool Sacar(double valor)
    {
        if (valor > this.saldo)
        {
            return false;
        }
        
        this.saldo -= valor;
        return true;
        
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaPoupanca contaDestino)
    {
        if (valor > this.saldo)
        {
            return false;
        }
        
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
     
    }


}