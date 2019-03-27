using System;
using cotacao.domains.Exceptions;
using cotacao.domains.ValueObjects;
using Xunit;

namespace cotacao.domains.tests
{
    public class MoedaTests
    {
        [Fact]
        public void ShouldCreateMoeda()
        {
            Assert.Equal(Moeda.Criar("brl"), "BRL");
        }

        [Fact]
        public void ShouldThrowException()
        {
            Assert.Throws<MoedaInvalidaException>(() => (Moeda)"ab");
        }
    }
}
