using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args){
    }

    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            
        }
    }

    public interface IPagamento
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
};
