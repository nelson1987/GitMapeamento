namespace Ephimes.Domain.Entities.Tipos
{
    /// <summary>
    ///     Ficha Cadastral enviada em Compartilhamento
    /// </summary>
    public class FichaCompartilhada : FichaCadastral
    {
        public FichaCompartilhada(Compartilhamento compartilhamento)
        {
            Compartilhamento = compartilhamento;
        }

        public Compartilhamento Compartilhamento { get; private set; }
    }
}