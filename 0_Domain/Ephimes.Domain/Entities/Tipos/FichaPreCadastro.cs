namespace Ephimes.Domain.Entities.Tipos
{
    /// <summary>
    ///     Ficha Cadastral de Empresa não saneada pelo sistema
    /// </summary>
    public class FichaPreCadastro : FichaCadastral
    {
        public FichaPreCadastro(Importacao compartilhamento)
        {
            Importacao = compartilhamento;
        }

        public Importacao Importacao { get; private set; }
    }
}