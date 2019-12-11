using System;
using System.Runtime.Serialization;

namespace _2019TobbformosMvcPizzaEgyTabla
{
    [Serializable]
    internal class FutarTelValidation : Exception
    {
        public FutarTelValidation()
        {
        }

        public FutarTelValidation(string message) : base(message)
        {
        }

        public FutarTelValidation(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FutarTelValidation(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}