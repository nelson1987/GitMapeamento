namespace Ephimes.Domain.Entities
{
    public class Usuario
    {
        protected Usuario()
        {
        }

        public Usuario(string login)
        {
            Login = login;
        }

        public string Login { get; private set; }
    }
}