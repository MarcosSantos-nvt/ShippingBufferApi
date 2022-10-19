namespace Domain.Dtos
{
    public class UnidadeMovimentacaoEntradaDto
    {
        public long UnidadeMovimentacaoId { get; set; }
        public int UnidadeMovimentacaoCodigo { get; set; }
        public string TipoProduto { get; set; }
        public string FilialDestino { get; set; }
        public string ClasseABC { get; set; }
    }
}
