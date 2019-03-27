namespace cotacao.domains.Exceptions
{
    [System.Serializable]
    public class MoedaInvalidaException : System.Exception
    {
        public MoedaInvalidaException() { }
        public MoedaInvalidaException(string message) : base(message) { }
        public MoedaInvalidaException(string message, System.Exception inner) : base(message, inner) { }
        protected MoedaInvalidaException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}