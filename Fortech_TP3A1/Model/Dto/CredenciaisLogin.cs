namespace Fortech_TP3A1.Model.Dto
{
    public class CredenciaisLogin
    {
        public string email { get; set; }
        public string senha { get; set; }

        public CredenciaisLogin()
        {
        }

        public CredenciaisLogin(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }
    }
}