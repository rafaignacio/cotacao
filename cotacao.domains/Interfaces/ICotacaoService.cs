using cotacao.domains.ValueObjects;

namespace cotacao.domains.Interfaces
{
    public interface ICotacaoService
    {
        double ObterCotacao(Moeda local, Moeda estrangeira);
    }
}