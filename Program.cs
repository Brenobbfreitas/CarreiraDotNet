using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args){
    }

    public abstract class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            
        }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public interface IPagamento
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
};
