using System;

namespace Aula08Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 700;
            visa.AumentarLimite(visa.limite, 500);
            visa.Pagar(342);
        }
    }
}
