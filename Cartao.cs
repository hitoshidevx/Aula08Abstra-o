namespace Aula08Abstração
{
    public class Cartao : Pagamento
    {
        public string titular { get; set; }
        public float numero { get; set; }
        public string bandeira { get; set; }
        protected int cvv { get; set; }
        private string token = "jr98yu9843hfeiwo8wefw9fu98wef98wu";
        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}