namespace Aula08Abstração
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public float AumentarLimite(float limite, float acrescimo){
            return limite + acrescimo;
        }
        public string Bloquear(){
            return "Cartão de crédito bloqueado.";
        }
    }
}