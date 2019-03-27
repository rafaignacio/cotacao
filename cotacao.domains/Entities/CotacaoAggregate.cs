using cotacao.domains.Exceptions;
using cotacao.domains.Interfaces;
using cotacao.domains.ValueObjects;

namespace cotacao.domains.Entities
{
    public class CotacaoAggregate
    {
        private ICotacaoService _service = null;

        private CotacaoAggregate(ICotacaoService service)
        {
            _service = service;
        }

        public CotacaoResponse EfetuarCotacao(CotacaoRequest request)
        {
            var cotacao = _service.ObterCotacao(request.Local, request.Estrangeira);

            return CotacaoResponse.Criar(request.Local, request.Estrangeira,
                request.ValorEstrangeira, cotacao);
        }

        public static CotacaoAggregate Criar(ICotacaoService service)
        {
            if (service == null)
            {
                throw new CotacaoServiceNullReferenceException();
            }

            return new CotacaoAggregate(service);
        }
    }
}