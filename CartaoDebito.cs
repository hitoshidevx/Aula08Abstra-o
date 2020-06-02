namespace Aula08Abstração
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string Transferir(float valor){
            return $"R${valor} transferido para sua conta.";
        }
        public string PagarTitulo(){
            return "Título pago com o cartão.";
        }
    }
}