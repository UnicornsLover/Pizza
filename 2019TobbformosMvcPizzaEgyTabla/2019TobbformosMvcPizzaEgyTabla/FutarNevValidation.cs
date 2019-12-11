using System;
using System.Runtime.Serialization;

namespace _2019TobbformosMvcPizzaEgyTabla
{
    [Serializable]
    internal class FutarNevValidation : Exception
    {
        public FutarNevValidation()
        {
        }

        public FutarNevValidation(string message) : base(message)
        {
        }

        public FutarNevValidation(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FutarNevValidation(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}