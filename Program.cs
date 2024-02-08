using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args){
        var pagamento = new PagamentoCartao();
        pagamento.Pagar("123");
    }
}



public class Pagamento
{
    //metodo constutor
    public Pagamento()
    {
        Console.WriteLine("Iniciando Pagamento");
    }
    public virtual void Pagar(string numero)
    {
        Console.WriteLine("Pagar");
    }
}

public class PagamentoCartao : Pagamento
{
    public override void Pagar(string numero)
    {
        base.Pagar(numero);
        Console.WriteLine("Cartão pago ");
    }
}