using Xunit;
using cotacao.domains.Exceptions;
using cotacao.domains.ValueObjects;
using cotacao.domains.Entities;
using cotacao.domains.Interfaces;

namespace cotacao.domains.tests
{
    public class CotacaoAggregateTest
    {
        [Fact]
        public void ShouldReturnValue()
        {
            var service = new CotacaoServiceTest();
            var aggregate = CotacaoAggregate.Criar(service);

            var response = aggregate.EfetuarCotacao(CotacaoRequest.Criar("brl", "usd", 100.0, false, ""));

            Assert.NotNull(response);
        }
    }

    class CotacaoServiceTest : ICotacaoService
    {
        public double ObterCotacao(Moeda local, Moeda estrangeira)
        {
            return 3.8586484811;
        }
    }
}