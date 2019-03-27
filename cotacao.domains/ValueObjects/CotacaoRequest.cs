namespace cotacao.domains.ValueObjects
{
    public class CotacaoRequest
    {
        private CotacaoRequest(Moeda local, Moeda estrangeira, double valor_estrangeira,
            bool funcionario, string segmento)
        {
            Local = local;
            Estrangeira = estrangeira;
            ValorEstrangeira = valor_estrangeira;
            Funcionario = funcionario;
            Segmento = segmento;
        }

        public Moeda Local { get; private set; }
        public Moeda Estrangeira { get; private set; }
        public double ValorEstrangeira { get; private set; }
        public bool Funcionario { get; private set; }
        public string Segmento { get; private set; }

        public static CotacaoRequest Criar(Moeda local, Moeda estrangeira, double valor_estrangeira,
            bool funcionario, string segmento)
        {
            return new CotacaoRequest(local, estrangeira, valor_estrangeira, funcionario, segmento);
        }
    }
}