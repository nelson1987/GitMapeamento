namespace WebForLink.Domain.Entities.Tipos
{
    public class ImportacaoEmpresa : Importacao
    {
        public ImportacaoEmpresa(Contratante contratante, Arquivo arquivo)
            : base(contratante, arquivo)
        {
        }
    }
}