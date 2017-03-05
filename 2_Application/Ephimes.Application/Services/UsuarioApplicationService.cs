namespace Ephimes.Application.Services
{
    public class UsuarioApplicationService
    {
        protected UsuarioApplicationService()
        {
        }

        public UsuarioApplicationService(string login)
        {
            Login = login;
        }

        public string Login { get; private set; }
    }
}