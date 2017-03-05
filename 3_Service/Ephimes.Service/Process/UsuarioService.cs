namespace Ephimes.Service.Process
{
    public class UsuarioService
    {
        protected UsuarioService()
        {
        }

        public UsuarioService(string login)
        {
            Login = login;
        }

        public string Login { get; private set; }
    }
}