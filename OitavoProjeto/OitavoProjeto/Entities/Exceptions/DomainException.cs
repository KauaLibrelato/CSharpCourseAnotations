using System;

namespace OitavoProjeto.Entities.Exceptions {
    internal class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}
