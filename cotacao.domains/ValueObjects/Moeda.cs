using cotacao.domains.Exceptions;

namespace cotacao.domains.ValueObjects
{
    public class Moeda
    {
        private string _moeda = string.Empty;

        private Moeda(string moeda)
        {
            _moeda = moeda;
        }

        public static Moeda Criar(string valor)
        {
            if (valor?.Length != 3)
            {
                throw new MoedaInvalidaException($"'{valor}' não é um valor válido de moeda. Moeda deve conter 3 caracteres.");
            }

            return new Moeda(valor.ToUpper());
        }

        public static implicit operator string(Moeda valor)
        {
            return valor._moeda;
        }

        public static implicit operator Moeda(string valor)
        {
            return Criar(valor);
        }
    }
}