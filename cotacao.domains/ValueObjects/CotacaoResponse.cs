namespace cotacao.domains.ValueObjects
{
    public class CotacaoResponse
    {
        private CotacaoResponse(Moeda local, Moeda estrangeira, double valor_local,
            double valor_estrangeira, double iof, double valor_local_iof)
        {
            Local = local;
            Estrangeira = estrangeira;
            ValorLocal = valor_local;
            ValorEstrangeira = valor_estrangeira;
            ValorLocalComIOF = valor_local_iof;
            IOF = iof;
        }

        public Moeda Local { get; private set; }
        public Moeda Estrangeira { get; private set; }
        public double ValorLocal { get; private set; }
        public double ValorEstrangeira { get; private set; }
        public double ValorLocalComIOF { get; private set; }
        public double IOF { get; private set; }

        public static CotacaoResponse Criar(Moeda local, Moeda estrangeira, double valor_estrangeira,
            double valor_cotacao)
        {
            var valor_local = valor_cotacao * valor_estrangeira;
            var iof = valor_local * 0.0638;
            var valor_local_iof = valor_local + iof;

            return new CotacaoResponse(local, estrangeira, valor_local, valor_estrangeira,
                iof, valor_local_iof);
        }
    }
}