namespace cotacao.domains.Exceptions
{
    [System.Serializable]
    public class CotacaoServiceNullReferenceException : System.Exception
    {
        public CotacaoServiceNullReferenceException() { }
        public CotacaoServiceNullReferenceException(string message) : base(message) { }
        public CotacaoServiceNullReferenceException(string message, System.Exception inner) : base(message, inner) { }
        protected CotacaoServiceNullReferenceException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}